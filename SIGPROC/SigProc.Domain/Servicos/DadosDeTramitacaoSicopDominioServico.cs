using AutoMapper;
using ServiceSicop;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class DadosDeTramitacaoSicopDominioServico : BaseDominioServico<DadosDeTramitacaoSicop>, IDadosDeTramitacaoSicopDominioServico 
    {
        private readonly IDadosDeTramitacaoSicopRepositorio _repository;
        private IMapper _mapper;
        public DadosDeTramitacaoSicopDominioServico(IDadosDeTramitacaoSicopRepositorio repository, IMapper mapper) : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
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
public class DadosDeTramitacaoSicopModelo
{
    public DadosDeTramitacaoSicopModelo()
    {
        Rotina = "";
        NumeroDoProcesso = "";
        Opcao = "";
        Item1 = "";
        MatDig_1 = "";
        MatRec_1 = "";
        OrgaoDeDestino_1 = "";
        DataDoDespacho_1 = "";
        Sequencia_1 = "";
        Guia_1 = "";
        Despacho_1 = "";

        Item2 = "";
        MatDig_2 = "";
        MatRec_2 = "";
        OrgaoDeDestino_2 = "";
        DataDoDespacho_2 = "";
        Sequencia_2 = "";
        Guia_2 = "";
        Despacho_2 = "";

        Item3 = "";
        MatDig_3 = "";
        MatRec_3 = "";
        OrgaoDeDestino_3 = "";
        DataDoDespacho_3 = "";
        Sequencia_3 = "";
        Guia_3 = "";
        Despacho_3 = "";

        Item4 = "";
        MatDig_4 = "";
        MatRec_4 = "";
        OrgaoDeDestino_4 = "";
        DataDoDespacho_4 = "";
        Sequencia_4 = "";
        Guia_4 = "";
        Despacho_4 = "";

        Item5 = "";
        MatDig_5 = "";
        MatRec_5 = "";
        OrgaoDeDestino_5 = "";
        DataDoDespacho_5 = "";
        Sequencia_5 = "";
        Guia_5 = "";
        Despacho_5 = "";

        Item6 = "";
        MatDig_6 = "";
        MatRec_6 = "";
        OrgaoDeDestino_6 = "";
        DataDoDespacho_6 = "";
        Sequencia_6 = "";
        Guia_6 = "";
        Despacho_6 = "";

        Item7 = "";
        MatDig_7 = "";
        MatRec_7 = "";
        OrgaoDeDestino_7 = "";
        DataDoDespacho_7 = "";
        Sequencia_7 = "";
        Guia_7 = "";
        Despacho_7 = "";

        Item8 = "";
        MatDig_8 = "";
        MatRec_8 = "";
        OrgaoDeDestino_8 = "";
        DataDoDespacho_8 = "";
        Sequencia_8 = "";
        Guia_8 = "";
        Despacho_8 = "";

        Item9 = "";
        MatDig_9 = "";
        MatRec_9 = "";
        OrgaoDeDestino_9 = "";
        DataDoDespacho_9 = "";
        Sequencia_9 = "";
        Guia_9 = "";
        Despacho_9 = "";

        Item10 = "";
        MatDig_10 = "";
        MatRec_10 = "";
        OrgaoDeDestino_10 = "";
        DataDoDespacho_10 = "";
        Sequencia_10 = "";
        Guia_10 = "";
        Despacho_10 = "";

        Item11 = "";
        MatDig_11 = "";
        MatRec_11 = "";
        OrgaoDeDestino_11 = "";
        DataDoDespacho_11 = "";
        Sequencia_11 = "";
        Guia_11 = "";
        Despacho_11 = "";

        Item12 = "";
        MatDig_12 = "";
        MatRec_12 = "";
        OrgaoDeDestino_12 = "";
        DataDoDespacho_12 = "";
        Sequencia_12 = "";
        Guia_12 = "";
        Despacho_12 = "";

        Item13 = "";
        MatDig_13 = "";
        MatRec_13 = "";
        OrgaoDeDestino_13 = "";
        DataDoDespacho_13 = "";
        Sequencia_13 = "";
        Guia_13 = "";
        Despacho_13 = "";

        Item14 = "";
        MatDig_14 = "";
        MatRec_14 = "";
        OrgaoDeDestino_14 = "";
        DataDoDespacho_14 = "";
        Sequencia_14 = "";
        Guia_14 = "";
        Despacho_14 = "";

        Concad = "";
        StatusLine = "";
    }

    public string Rotina { get; set; }
    public string NumeroDoProcesso { get; set; }
    public string Opcao { get; set; }

    public string Item1 { get; set; }
    public string MatDig_1 { get; set; }
    public string MatRec_1 { get; set; }
    public string OrgaoDeDestino_1 { get; set; }
    public string DataDoDespacho_1 { get; set; }
    public string Sequencia_1 { get; set; }
    public string Guia_1 { get; set; }
    public string Despacho_1 { get; set; }

    public string Item2 { get; set; }
    public string MatDig_2 { get; set; }
    public string MatRec_2 { get; set; }
    public string OrgaoDeDestino_2 { get; set; }
    public string DataDoDespacho_2 { get; set; }
    public string Sequencia_2 { get; set; }
    public string Guia_2 { get; set; }
    public string Despacho_2 { get; set; }

    public string Item3 { get; set; }
    public string MatDig_3 { get; set; }
    public string MatRec_3 { get; set; }
    public string OrgaoDeDestino_3 { get; set; }
    public string DataDoDespacho_3 { get; set; }
    public string Sequencia_3 { get; set; }
    public string Guia_3 { get; set; }
    public string Despacho_3 { get; set; }

    public string Item4 { get; set; }
    public string MatDig_4 { get; set; }
    public string MatRec_4 { get; set; }
    public string OrgaoDeDestino_4 { get; set; }
    public string DataDoDespacho_4 { get; set; }
    public string Sequencia_4 { get; set; }
    public string Guia_4 { get; set; }
    public string Despacho_4 { get; set; }

    public string Item5 { get; set; }
    public string MatDig_5 { get; set; }
    public string MatRec_5 { get; set; }
    public string OrgaoDeDestino_5 { get; set; }
    public string DataDoDespacho_5 { get; set; }
    public string Sequencia_5 { get; set; }
    public string Guia_5 { get; set; }
    public string Despacho_5 { get; set; }

    public string Item6 { get; set; }
    public string MatDig_6 { get; set; }
    public string MatRec_6 { get; set; }
    public string OrgaoDeDestino_6 { get; set; }
    public string DataDoDespacho_6 { get; set; }
    public string Sequencia_6 { get; set; }
    public string Guia_6 { get; set; }
    public string Despacho_6 { get; set; }

    public string Item7 { get; set; }
    public string MatDig_7 { get; set; }
    public string MatRec_7 { get; set; }
    public string OrgaoDeDestino_7 { get; set; }
    public string DataDoDespacho_7 { get; set; }
    public string Sequencia_7 { get; set; }
    public string Guia_7 { get; set; }
    public string Despacho_7 { get; set; }

    public string Item8 { get; set; }
    public string MatDig_8 { get; set; }
    public string MatRec_8 { get; set; }
    public string OrgaoDeDestino_8 { get; set; }
    public string DataDoDespacho_8 { get; set; }
    public string Sequencia_8 { get; set; }
    public string Guia_8 { get; set; }
    public string Despacho_8 { get; set; }

    public string Item9 { get; set; }
    public string MatDig_9 { get; set; }
    public string MatRec_9 { get; set; }
    public string OrgaoDeDestino_9 { get; set; }
    public string DataDoDespacho_9 { get; set; }
    public string Sequencia_9 { get; set; }
    public string Guia_9 { get; set; }
    public string Despacho_9 { get; set; }

    public string Item10 { get; set; }
    public string MatDig_10 { get; set; }
    public string MatRec_10 { get; set; }
    public string OrgaoDeDestino_10 { get; set; }
    public string DataDoDespacho_10 { get; set; }
    public string Sequencia_10 { get; set; }
    public string Guia_10 { get; set; }
    public string Despacho_10 { get; set; }

    public string Item11 { get; set; }
    public string MatDig_11 { get; set; }
    public string MatRec_11 { get; set; }
    public string OrgaoDeDestino_11 { get; set; }
    public string DataDoDespacho_11 { get; set; }
    public string Sequencia_11 { get; set; }
    public string Guia_11 { get; set; }
    public string Despacho_11 { get; set; }

    public string Item12 { get; set; }
    public string MatDig_12 { get; set; }
    public string MatRec_12 { get; set; }
    public string OrgaoDeDestino_12 { get; set; }
    public string DataDoDespacho_12 { get; set; }
    public string Sequencia_12 { get; set; }
    public string Guia_12 { get; set; }
    public string Despacho_12 { get; set; }

    public string Item13 { get; set; }
    public string MatDig_13 { get; set; }
    public string MatRec_13 { get; set; }
    public string OrgaoDeDestino_13 { get; set; }
    public string DataDoDespacho_13 { get; set; }
    public string Sequencia_13 { get; set; }
    public string Guia_13 { get; set; }
    public string Despacho_13 { get; set; }

    public string Item14 { get; set; }
    public string MatDig_14 { get; set; }
    public string MatRec_14 { get; set; }
    public string OrgaoDeDestino_14 { get; set; }
    public string DataDoDespacho_14 { get; set; }
    public string Sequencia_14 { get; set; }
    public string Guia_14 { get; set; }
    public string Despacho_14 { get; set; }

    public string Concad { get; set; }
    public string StatusLine { get; set; }
}

