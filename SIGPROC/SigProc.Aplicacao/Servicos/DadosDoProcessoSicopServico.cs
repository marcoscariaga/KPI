using Serilog;
using ServiceSicop;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SigProc.Aplicacao.Servicos
{
    public class DadosDoProcessoSicopServico : BaseServico<DadosDoProcessoSicop>, IDadosDoProcessoSicopServico
    {
        private readonly IDadosDoProcessoSicopDominioServico _dadosRetornoDominioServico;

        public DadosDoProcessoSicopServico(IDadosDoProcessoSicopDominioServico dadosRetornoDominioServico) : base(dadosRetornoDominioServico)
        {
            _dadosRetornoDominioServico = dadosRetornoDominioServico;
        }

        WSSicopConsultaSoapClient servico = new WSSicopConsultaSoapClient(WSSicopConsultaSoapClient.EndpointConfiguration.WSSicopConsultaSoap12);

        public DadosDoProcessoSicop ConsultarProcesso(string numeroProcesso)
        {
            return consultarProcesso(new DadosDoProcessoSicopModelo
            {
                Metodo = "ConsultaProcesso_WS",
                Rotina = "3010",
                Numprocesso = numeroProcesso.Replace("/", "")
            });
        }
        private DadosDoProcessoSicop consultarProcesso(DadosDoProcessoSicopModelo processo)
        {
            return consultar(processo.Rotina, processo.Metodo, () =>
            {
                var resultado = servico.TConsultaProcesso_WS("", processo.Numprocesso);
                if (resultado == null)
                {
                    return DadosDoProcessoSicop.ComMensagem("Erro: A rotina SICOP não retornou mensagem.");
                }

                var erro = resultado as RuntimeError;

                if (erro != null)
                {
                    return DadosDoProcessoSicop.ComMensagem(string.Format("Erro ao executar processamento do SICOP. Código: {0}, Mensagem: {1}", erro.ErrorCode, erro.ErrorMessage));
                }

                if (resultado is ConsultaProcesso_WS)
                {
                    return DadosDoProcessoSicop.Criar(resultado as ConsultaProcesso_WS);
                }

                return DadosDoProcessoSicop.ComMensagem("Erro: A rotina SICOP não retornou mensagem.");
            },
            () => servico.TConsultaProcesso_WS("FIM", ""));
        }
        private DadosDoProcessoSicop consultar(string rotina, string metodo, Func<DadosDoProcessoSicop> acao, Action fim)
        {
            try
            {
                Configurar();
                try
                {
                    if (naoConectado(servico.Connect().MessageClassName))
                    {
                        return DadosDoProcessoSicop.ComMensagem(string.Format("Não foi possível estabelecer CONEXÃO com o SICOP para a operação '{0}' rotina: '{1}'.", metodo, rotina));
                    }
                    try
                    {
                        var senha = "";
                        var matricula = "";
                        var novasenha = "";
                        if (naoLogado(servico.TLogonSicop_WS(rotina, matricula, senha, novasenha).MessageClassName, metodo))
                        {

                            return DadosDoProcessoSicop.ComMensagem(string.Format("Não foi possível estabelecer o LOGIN no Sicop para a operação '{0}' rotina: '{1}'.", metodo, rotina));
                        }
                        try
                        {
                            var resultado = acao();

                            if (resultado.StatusLine.ToLower().Equals("processo nao cadastrado"))
                            {
                                resultado.StatusLine = "Processo não cadastrado no Sicop.";
                            }

                            return resultado;
                        }
                        catch (Exception)
                        {
                            Log.ForContext("Acao", $"ProcessoSICOP").Information($"Processo não cadastrado no Sicop.");
                            throw new Exception("Processo não cadastrado no Sicop");
                        }
                       
                    }
                    catch (Exception)
                    {
                        Log.ForContext("Acao", $"LoginSICOP").Information($"Não foi possível estabelecer o LOGIN no Sicop para a operação ConsultaProcesso_WS.");
                        throw new Exception("Não foi possível estabelecer o LOGIN no Sicop para a operação ConsultaProcesso_WS.");
                    }

                   
                }
                catch (Exception)
                {
                    Log.ForContext("Acao", $"ConexãoSICOP").Information($"Não foi possível estabelecer CONEXÃO com o SICOP para a operação ConsultaProcesso_WS.");
                    throw new Exception("Não foi possível estabelecer CONEXÃO com o SICOP para a operação ConsultaProcesso_WS.");
                }
               
            }
            catch (Exception)
            {
                Log.ForContext("Acao", $"ServicoSICOP").Information($"Serviço SICOP indisponível.");
                throw new Exception("Serviço SICOP indisponível.");
            }    
            
        }
        public void Configurar()
        {
            var i = 0;
            var bec = servico.Endpoint.Binding.CreateBindingElements();
            var bea = new BindingElement[bec.Count];
            foreach (var be in bec)
            {
                bea[i] = be;
                if (be is HttpTransportBindingElement)
                    ((HttpTransportBindingElement)be).AllowCookies = true;
                i++;
            }
            var customBinding = new CustomBinding(bea);
            servico.Endpoint.Binding = customBinding;
        }
        private static bool naoConectado(string mensagem)
        {
            return operacaoNaoRealizada(mensagem, "LogonSicop_WS");
        }
        private static bool operacaoNaoRealizada(string mensagem, string metodo)
        {
            if (mensagem == null || !string.Equals(mensagem, metodo, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }
        private static bool naoLogado(string mensagem, string metodo)
        {
            return operacaoNaoRealizada(mensagem, metodo);
        }
    }
}
