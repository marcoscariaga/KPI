using ServiceSicop;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class DadosDeTramitacaoSicopServico : BaseServico<DadosDeTramitacaoSicop>, IDadosDeTramitacaoSicopServico
    {
        private readonly IDadosDeTramitacaoSicopDominioServico dadosDeTramitacaoSicopDominioServico;

        public DadosDeTramitacaoSicopServico(IDadosDeTramitacaoSicopDominioServico dadosDeTramitacaoSicopDominioServico) : base(dadosDeTramitacaoSicopDominioServico)
        {
            this.dadosDeTramitacaoSicopDominioServico = dadosDeTramitacaoSicopDominioServico;
        }
        WSSicopConsultaSoapClient servico = new WSSicopConsultaSoapClient(WSSicopConsultaSoapClient.EndpointConfiguration.WSSicopConsultaSoap12);

        public virtual DadosDeTramitacaoSicop ConsultarProcesso(string numero)
        {
            return consultarProcesso(new DadosDeTramitacaoSicopModelo
            {
                Rotina = "3110",
                NumeroDoProcesso = numero.Replace("/", "")
            });
        }

        private DadosDeTramitacaoSicop consultarProcesso(DadosDeTramitacaoSicopModelo processo)
        {
            return consultar(processo.Rotina, () =>
            {
                var resultado = servico.TConsultaTodaTramitacaoProcesso_WS("", "", processo.NumeroDoProcesso, "");
                if (resultado == null)
                {
                    return DadosDeTramitacaoSicop.ComMensagem("Erro: A rotina SICOP não retornou mensagem.");
                }

                var erro = resultado as RuntimeError;

                if (erro != null)
                {
                    return DadosDeTramitacaoSicop.ComMensagem(string.Format("Erro ao executar processamento do SICOP. Código: {0}, Mensagem: {1}", erro.ErrorCode, erro.ErrorMessage));
                }

                if (resultado is ConsultaTodaTramitacaoProcesso_WS)
                {
                    return DadosDeTramitacaoSicop.Criar(resultado as ConsultaTodaTramitacaoProcesso_WS);
                }

                return DadosDeTramitacaoSicop.ComMensagem("Erro: A rotina SICOP não retornou mensagem.");
            },
            () => servico.TConsultaTodaTramitacaoProcesso_WS("FIM", "", "", ""));
        }

        private DadosDeTramitacaoSicop consultar(string rotina, Func<DadosDeTramitacaoSicop> acao, Action fim)
        {
            Configurar();

            if (naoConectado(servico.Connect().MessageClassName))
            {
                return DadosDeTramitacaoSicop.ComMensagem(string.Format("Não foi possível estabelecer CONEXÃO com o SICOP para a operação '{0}' rotina: '{1}'.", rotina));
            }

            if (naoLogado(servico.TLogonSicop_WS("3110", "", "", "").MessageClassName))
            {

                return DadosDeTramitacaoSicop.ComMensagem(string.Format("Não foi possível estabelecer o LOGIN no Sicop para a operação '{0}' rotina: '{1}'.", rotina));
            }

            var resultado = acao();

            if (resultado.StatusLine.ToLower().Equals("processo nao cadastrado"))
            {
                resultado.StatusLine = "Processo não cadastrado no Sicop.";
            }

            return resultado;
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
            return operacaoNaoRealizada(mensagem);
        }
        private static bool operacaoNaoRealizada(string mensagem)
        {
            return false;
        }
        private static bool naoLogado(string mensagem)
        {
            return operacaoNaoRealizada(mensagem);
        }
    }
}
