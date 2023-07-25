using ServiceSicop;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Entidades
{
    public class DadosDoProcessoSicop : Base
    {
        /// <summary>
        /// Rotina
        /// </summary>
        public string Rotina { get; set; }

        /// <summary>
        /// Número do Processo
        /// </summary>
        public string NumeroDoProcesso { get; set; }

        /// <summary>
        /// Documentação do identificador
        /// </summary>
        public string DocumentacaoDoIdentificador { get; set; }

        /// <summary>
        /// Informação do Volume
        /// </summary>
        public string InformacaoVolume { get; set; }

        /// <summary>
        /// Informação de tela
        /// </summary>
        public string InformacaoTela { get; set; }

        /// <summary>
        /// Pasta de Assentamento
        /// </summary>
        public string PastaDeAssentamento { get; set; }

        /// <summary>
        /// Nome do requerente
        /// </summary>
        public string NomeDoRequerente { get; set; }

        /// <summary>
        /// Órgão de Origem
        /// </summary>
        public string OrgaoDeOrigem { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Cep
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Tipo do documento
        /// </summary>
        public string TipoDoDocumento { get; set; }

        /// <summary>
        /// Descrição do tipo de documento
        /// </summary>
        public string DescricaoDoTipoDoDocumento { get; set; }

        /// <summary>
        /// Número do tipo de documento
        /// </summary>
        public string NumeroDoTipoDoDocumento { get; set; }

        /// <summary>
        /// Órgão do documento
        /// </summary>
        public string OrgaoDoDocumento { get; set; }

        /// <summary>
        /// Informação de tela 1
        /// </summary>
        public string InformacaoTela1 { get; set; }

        /// <summary>
        /// Informação de tela 2
        /// </summary>
        public string InformacaoTela2 { get; set; }

        /// <summary>
        /// Informação de tela 3
        /// </summary>
        public string InformacaoTela3 { get; set; }

        /// <summary>
        /// Informação de tela 4
        /// </summary>
        public string InformacaoTela4 { get; set; }

        /// <summary>
        /// Informação de tela 5
        /// </summary>
        public string InformacaoTela5 { get; set; }

        /// <summary>
        /// Auto de infração
        /// </summary>
        public string AutoDeInfracao { get; set; }

        /// <summary>
        /// Informação de tela 6
        /// </summary>
        public string InformacaoTela6 { get; set; }

        /// <summary>
        /// Informação de tela 7
        /// </summary>
        public string InformacaoTela7 { get; set; }

        /// <summary>
        /// Informação de tela 8
        /// </summary>
        public string InformacaoTela8 { get; set; }

        /// <summary>
        /// Código do Assunto
        /// </summary>
        public string CodigoAssunto { get; set; }

        /// <summary>
        /// Informação complementar 1
        /// </summary>
        public string InformacaoComplementar1 { get; set; }

        /// <summary>
        /// Informação complementar 2
        /// </summary>
        public string InformacaoComplementar2 { get; set; }

        /// <summary>
        /// Informação complementar 3
        /// </summary>
        public string InformacaoComplementar3 { get; set; }

        /// <summary>
        /// Data do processo
        /// </summary>
        public string DataDoProcesso { get; set; }

        /// <summary>
        /// Data de cadastro do processo
        /// </summary>
        public string DataDeCadastroDeProcesso { get; set; }

        /// <summary>
        /// Hora de cadastro do processo
        /// </summary>
        public string HoraDeCadastroDoProcesso { get; set; }

        /// <summary>
        /// Matrícula do recebedor
        /// </summary>
        public string MatriculaRecebedorCadastro { get; set; }

        /// <summary>
        /// Matrícula do digitador
        /// </summary>
        public string MatriculaDigitadorProcesso { get; set; }

        /// <summary>
        /// Processo principal
        /// </summary>
        public string ProcessoPrincipal { get; set; }

        /// <summary>
        /// Identificação do processo
        /// </summary>
        public string IdentificacaoProcesso { get; set; }

        /// <summary>
        /// Novo posicionamento
        /// </summary>
        public string NovoPosicionamento { get; set; }

        /// <summary>
        /// Informação de tela 9
        /// </summary>
        public string InformacaoTela9 { get; set; }

        /// <summary>
        /// Informação de tela 10
        /// </summary>
        public string InformacaoTela10 { get; set; }

        /// <summary>
        /// Matrícula do digitador na tramitação
        /// </summary>
        public string MatriculaDigitadorTramitacao { get; set; }

        /// <summary>
        /// Data da digitação na tramitação
        /// </summary>
        public string DataDigitacaoTramitacao { get; set; }

        /// <summary>
        /// Data do recebimento da tramitação
        /// </summary>
        public string DataDeRecebimentoTramitacao { get; set; }

        /// <summary>
        /// Informação de tela 11
        /// </summary>
        public string InformacaoTela11 { get; set; }

        /// <summary>
        /// Informação de tela 12
        /// </summary>
        public string InformacaoTela12 { get; set; }

        /// <summary>
        /// Data de despacho da tramitação
        /// </summary>
        public string DataDeDespachoTramitacao { get; set; }

        /// <summary>
        /// Matrícula do despacho na tramitação
        /// </summary>
        public string MatriculaDoDespachoTramitacao { get; set; }

        /// <summary>
        /// Matrícula do recebedor na tramitação
        /// </summary>
        public string MatriculaDoRecebedorTramitacao { get; set; }

        /// <summary>
        /// Número da guia na tramitação
        /// </summary>
        public string NumeroGuiaTramitacao { get; set; }

        /// <summary>
        /// Sequência na tramitação
        /// </summary>
        public string SequenciaTramitacao { get; set; }

        /// <summary>
        /// Órgão de origem na tramitação
        /// </summary>
        public string OrgaoOrigemTramitacao { get; set; }

        /// <summary>
        /// Órgão de destino na tramitação
        /// </summary>
        public string OrgaoDestinoTramitacao { get; set; }

        /// <summary>
        /// Endereço de destino do processo na tramitação
        /// </summary>
        public string EnderecoDestinoProcessoTramitacao { get; set; }

        /// <summary>
        /// Despacho do processo na tramitação
        /// </summary>
        public string DespachoProcessoTramitacao { get; set; }

        /// <summary>
        /// Status line
        /// </summary>
        public string StatusLine { get; set; }
        public static DadosDoProcessoSicop ComMensagem(string erro)
        {
            return new DadosDoProcessoSicop
            {
                StatusLine = erro
            };
        }

        /// <summary>
        /// Cria um novo DadosDeRetornoSicop apartir dos dados retornados pelo serviço
        /// </summary>
        /// <param name="detalhamento">Dados retornado pelo serviço</param>
        /// <returns>Retorna um DadosDeRetornoSicop</returns>
        public static DadosDoProcessoSicop Criar(ConsultaProcesso_WS detalhamento)
        {
            return new DadosDoProcessoSicop
            {
                Rotina = "",
                NumeroDoProcesso = detalhamento.NRPROCESSO.Trim(),
                DocumentacaoDoIdentificador = detalhamento.DOCIDENTIFICADOR.Trim(),
                InformacaoVolume = detalhamento.INFVOLUME.Trim(),
                InformacaoTela = detalhamento.NOMREQUERENTE.Trim(),
                PastaDeAssentamento = detalhamento.PASTAASSENTAMENTO.Trim(),
                NomeDoRequerente = detalhamento.NOMREQUERENTE.Trim(),
                OrgaoDeOrigem = detalhamento.ORGORIGEM.Trim(),
                Endereco = detalhamento.ENDERECO.Trim(),
                Cep = detalhamento.CEP.Trim(),
                Bairro = detalhamento.BAIRRO.Trim(),
                Telefone = detalhamento.TELEFONE.Trim(),
                TipoDoDocumento = detalhamento.TIPODOC.Trim(),
                DescricaoDoTipoDoDocumento = detalhamento.DESCRTPDOC.Trim(),
                NumeroDoTipoDoDocumento = detalhamento.NRTPDOC.Trim(),
                OrgaoDoDocumento = detalhamento.ORGAODOC.Trim(),
                InformacaoTela1 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela2 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela3 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela4 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela5 = detalhamento.ORGAODOC.Trim(),
                AutoDeInfracao = detalhamento.ORGAODOC.Trim(),
                InformacaoTela6 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela7 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela8 = detalhamento.ORGAODOC.Trim(),
                CodigoAssunto = detalhamento.CODASSUNTO.Trim(),
                InformacaoComplementar1 = detalhamento.INFCOMPL1.Trim(),
                InformacaoComplementar2 = detalhamento.INFCOMPL2.Trim(),
                InformacaoComplementar3 = detalhamento.INFCOMPL3.Trim(),
                DataDoProcesso = detalhamento.DATAPROCESSO.Trim(),
                DataDeCadastroDeProcesso = detalhamento.DATACADPROCESSO.Trim(),
                HoraDeCadastroDoProcesso = detalhamento.HORACADPROCESSO.Trim(),
                MatriculaRecebedorCadastro = detalhamento.MATRRECEBCADPROCESSO.Trim(),
                MatriculaDigitadorProcesso = detalhamento.MATRDIGPROCESSO.Trim(),
                ProcessoPrincipal = detalhamento.PROCESSOPRINCIPAL.Trim(),
                IdentificacaoProcesso = detalhamento.IDENTIFICAPROCESSO.Trim(),
                NovoPosicionamento = detalhamento.NOVOPOSICIONAMENTO.Trim(),
                InformacaoTela9 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela10 = detalhamento.ORGAODOC.Trim(),
                MatriculaDigitadorTramitacao = detalhamento.MATRDIGTRAM.Trim(),
                DataDigitacaoTramitacao = detalhamento.DATADIGTRAM.Trim(),
                DataDeRecebimentoTramitacao = detalhamento.DATARECEBIMENTOTRAM.Trim(),
                InformacaoTela11 = detalhamento.ORGAODOC.Trim(),
                InformacaoTela12 = detalhamento.ORGAODOC.Trim(),
                DataDeDespachoTramitacao = detalhamento.DATADESPACHOTRAM.Trim(),
                MatriculaDoDespachoTramitacao = detalhamento.MATRDESPACHOUPROCESSO.Trim(),
                MatriculaDoRecebedorTramitacao = detalhamento.MATRRECEBEUPROCESSO.Trim(),
                NumeroGuiaTramitacao = detalhamento.NRGUIATRAM.Trim(),
                SequenciaTramitacao = detalhamento.SEQTRAM.Trim(),
                OrgaoOrigemTramitacao = detalhamento.ORGAOORIGEM.Trim(),
                OrgaoDestinoTramitacao = detalhamento.ORGAODESTINO.Trim(),
                EnderecoDestinoProcessoTramitacao = detalhamento.ENDDESTINOPROCESSO.Trim(),
                DespachoProcessoTramitacao = detalhamento.DESPACHOPROCESSO.Trim(),
                StatusLine = detalhamento.StatusLine == null ? "" : detalhamento.StatusLine.Trim()
            };
        }
    }
}
