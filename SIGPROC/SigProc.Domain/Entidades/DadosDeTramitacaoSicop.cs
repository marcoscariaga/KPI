using ServiceSicop;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Entidades
{
    public class DadosDeTramitacaoSicop : Base
    {
        public string Rotina { get; set; }
        public string NumeroDoProcesso { get; set; }
        public string Opcao { get; set; }

        public string Item_01 { get; set; }
        public string MatDig_01 { get; set; }
        public string MatRec_01 { get; set; }
        public string OrgaoDeDestino_01 { get; set; }
        public string DataDoDespacho_01 { get; set; }
        public string Sequencia_01 { get; set; }
        public string Guia_01 { get; set; }
        public string Despacho_01 { get; set; }

        public string Item_02 { get; set; }
        public string MatDig_02 { get; set; }
        public string MatRec_02 { get; set; }
        public string OrgaoDeDestino_02 { get; set; }
        public string DataDoDespacho_02 { get; set; }
        public string Sequencia_02 { get; set; }
        public string Guia_02 { get; set; }
        public string Despacho_02 { get; set; }

        public string Item_03 { get; set; }
        public string MatDig_03 { get; set; }
        public string MatRec_03 { get; set; }
        public string OrgaoDeDestino_03 { get; set; }
        public string DataDoDespacho_03 { get; set; }
        public string Sequencia_03 { get; set; }
        public string Guia_03 { get; set; }
        public string Despacho_03 { get; set; }

        public string Item_04 { get; set; }
        public string MatDig_04 { get; set; }
        public string MatRec_04 { get; set; }
        public string OrgaoDeDestino_04 { get; set; }
        public string DataDoDespacho_04 { get; set; }
        public string Sequencia_04 { get; set; }
        public string Guia_04 { get; set; }
        public string Despacho_04 { get; set; }

        public string Item_05 { get; set; }
        public string MatDig_05 { get; set; }
        public string MatRec_05 { get; set; }
        public string OrgaoDeDestino_05 { get; set; }
        public string DataDoDespacho_05 { get; set; }
        public string Sequencia_05 { get; set; }
        public string Guia_05 { get; set; }
        public string Despacho_05 { get; set; }

        public string Item_06 { get; set; }
        public string MatDig_06 { get; set; }
        public string MatRec_06 { get; set; }
        public string OrgaoDeDestino_06 { get; set; }
        public string DataDoDespacho_06 { get; set; }
        public string Sequencia_06 { get; set; }
        public string Guia_06 { get; set; }
        public string Despacho_06 { get; set; }

        public string Item_07 { get; set; }
        public string MatDig_07 { get; set; }
        public string MatRec_07 { get; set; }
        public string OrgaoDeDestino_07 { get; set; }
        public string DataDoDespacho_07 { get; set; }
        public string Sequencia_07 { get; set; }
        public string Guia_07 { get; set; }
        public string Despacho_07 { get; set; }

        public string Item_08 { get; set; }
        public string MatDig_08 { get; set; }
        public string MatRec_08 { get; set; }
        public string OrgaoDeDestino_08 { get; set; }
        public string DataDoDespacho_08 { get; set; }
        public string Sequencia_08 { get; set; }
        public string Guia_08 { get; set; }
        public string Despacho_08 { get; set; }

        public string Item_09 { get; set; }
        public string MatDig_09 { get; set; }
        public string MatRec_09 { get; set; }
        public string OrgaoDeDestino_09 { get; set; }
        public string DataDoDespacho_09 { get; set; }
        public string Sequencia_09 { get; set; }
        public string Guia_09 { get; set; }
        public string Despacho_09 { get; set; }

        public string Item_10 { get; set; }
        public string MatDig_10 { get; set; }
        public string MatRec_10 { get; set; }
        public string OrgaoDeDestino_10 { get; set; }
        public string DataDoDespacho_10 { get; set; }
        public string Sequencia_10 { get; set; }
        public string Guia_10 { get; set; }
        public string Despacho_10 { get; set; }

        public string Item_11 { get; set; }
        public string MatDig_11 { get; set; }
        public string MatRec_11 { get; set; }
        public string OrgaoDeDestino_11 { get; set; }
        public string DataDoDespacho_11 { get; set; }
        public string Sequencia_11 { get; set; }
        public string Guia_11 { get; set; }
        public string Despacho_11 { get; set; }

        public string Item_12 { get; set; }
        public string MatDig_12 { get; set; }
        public string MatRec_12 { get; set; }
        public string OrgaoDeDestino_12 { get; set; }
        public string DataDoDespacho_12 { get; set; }
        public string Sequencia_12 { get; set; }
        public string Guia_12 { get; set; }
        public string Despacho_12 { get; set; }

        public string Item_13 { get; set; }
        public string MatDig_13 { get; set; }
        public string MatRec_13 { get; set; }
        public string OrgaoDeDestino_13 { get; set; }
        public string DataDoDespacho_13 { get; set; }
        public string Sequencia_13 { get; set; }
        public string Guia_13 { get; set; }
        public string Despacho_13 { get; set; }

        public string Item_14 { get; set; }
        public string MatDig_14 { get; set; }
        public string MatRec_14 { get; set; }
        public string OrgaoDeDestino_14 { get; set; }
        public string DataDoDespacho_14 { get; set; }
        public string Sequencia_14 { get; set; }
        public string Guia_14 { get; set; }
        public string Despacho_14 { get; set; }

        public string Concad { get; set; }
        public string StatusLine { get; set; }

        public static DadosDeTramitacaoSicop ComMensagem(string erro)
        {
            return new DadosDeTramitacaoSicop
            {
                StatusLine = erro
            };
        }

        /// <summary>
        /// Cria um novo DadosDeRetornoSicop apartir dos dados retornados pelo serviço
        /// </summary>
        /// <param name="detalhamento">Dados retornado pelo serviço</param>
        /// <returns>Retorna um DadosDeRetornoSicop</returns>
        public static DadosDeTramitacaoSicop Criar(ConsultaTodaTramitacaoProcesso_WS detalhamento)
        {
            return new DadosDeTramitacaoSicop
            {
                Rotina = "",
                NumeroDoProcesso = detalhamento.NUMPROC.Trim(),
                Opcao = detalhamento.OPCAO.Trim(),

                Item_01 = detalhamento.ITEM1.Trim(),
                MatDig_01 = detalhamento.MATDIG1.Trim(),
                MatRec_01 = detalhamento.MATREC1.Trim(),
                OrgaoDeDestino_01 = detalhamento.ORGDEST1.Trim(),
                DataDoDespacho_01 = detalhamento.DATDESP1.Trim(),
                Sequencia_01 = detalhamento.SEQ1.Trim(),
                Guia_01 = detalhamento.GUIA1.Trim(),
                Despacho_01 = detalhamento.DESPACHO1.Trim(),

                Item_02 = detalhamento.ITEM2.Trim(),
                MatDig_02 = detalhamento.MATDIG2.Trim(),
                MatRec_02 = detalhamento.MATREC2.Trim(),
                OrgaoDeDestino_02 = detalhamento.ORGDEST2.Trim(),
                DataDoDespacho_02 = detalhamento.DATDESP2.Trim(),
                Sequencia_02 = detalhamento.SEQ2.Trim(),
                Guia_02 = detalhamento.GUIA2.Trim(),
                Despacho_02 = detalhamento.DESPACHO2.Trim(),

                Item_03 = detalhamento.ITEM3.Trim(),
                MatDig_03 = detalhamento.MATDIG3.Trim(),
                MatRec_03 = detalhamento.MATREC3.Trim(),
                OrgaoDeDestino_03 = detalhamento.ORGDEST3.Trim(),
                DataDoDespacho_03 = detalhamento.DATDESP3.Trim(),
                Sequencia_03 = detalhamento.SEQ3.Trim(),
                Guia_03 = detalhamento.GUIA3.Trim(),
                Despacho_03 = detalhamento.DESPACHO3.Trim(),

                Item_04 = detalhamento.ITEM4.Trim(),
                MatDig_04 = detalhamento.MATDIG4.Trim(),
                MatRec_04 = detalhamento.MATREC4.Trim(),
                OrgaoDeDestino_04 = detalhamento.ORGDEST4.Trim(),
                DataDoDespacho_04 = detalhamento.DATDESP4.Trim(),
                Sequencia_04 = detalhamento.SEQ4.Trim(),
                Guia_04 = detalhamento.GUIA4.Trim(),
                Despacho_04 = detalhamento.DESPACHO4.Trim(),

                Item_05 = detalhamento.ITEM5.Trim(),
                MatDig_05 = detalhamento.MATDIG5.Trim(),
                MatRec_05 = detalhamento.MATREC5.Trim(),
                OrgaoDeDestino_05 = detalhamento.ORGDEST5.Trim(),
                DataDoDespacho_05 = detalhamento.DATDESP5.Trim(),
                Sequencia_05 = detalhamento.SEQ5.Trim(),
                Guia_05 = detalhamento.GUIA5.Trim(),
                Despacho_05 = detalhamento.DESPACHO5.Trim(),

                Item_06 = detalhamento.ITEM6.Trim(),
                MatDig_06 = detalhamento.MATDIG6.Trim(),
                MatRec_06 = detalhamento.MATREC6.Trim(),
                OrgaoDeDestino_06 = detalhamento.ORGDEST6.Trim(),
                DataDoDespacho_06 = detalhamento.DATDESP6.Trim(),
                Sequencia_06 = detalhamento.SEQ6.Trim(),
                Guia_06 = detalhamento.GUIA6.Trim(),
                Despacho_06 = detalhamento.DESPACHO6.Trim(),

                Item_07 = detalhamento.ITEM7.Trim(),
                MatDig_07 = detalhamento.MATDIG7.Trim(),
                MatRec_07 = detalhamento.MATREC7.Trim(),
                OrgaoDeDestino_07 = detalhamento.ORGDEST7.Trim(),
                DataDoDespacho_07 = detalhamento.DATDESP7.Trim(),
                Sequencia_07 = detalhamento.SEQ7.Trim(),
                Guia_07 = detalhamento.GUIA7.Trim(),
                Despacho_07 = detalhamento.DESPACHO7.Trim(),

                Item_08 = detalhamento.ITEM8.Trim(),
                MatDig_08 = detalhamento.MATDIG8.Trim(),
                MatRec_08 = detalhamento.MATREC8.Trim(),
                OrgaoDeDestino_08 = detalhamento.ORGDEST8.Trim(),
                DataDoDespacho_08 = detalhamento.DATDESP8.Trim(),
                Sequencia_08 = detalhamento.SEQ8.Trim(),
                Guia_08 = detalhamento.GUIA8.Trim(),
                Despacho_08 = detalhamento.DESPACHO8.Trim(),

                Item_09 = detalhamento.ITEM9.Trim(),
                MatDig_09 = detalhamento.MATDIG9.Trim(),
                MatRec_09 = detalhamento.MATREC9.Trim(),
                OrgaoDeDestino_09 = detalhamento.ORGDEST9.Trim(),
                DataDoDespacho_09 = detalhamento.DATDESP9.Trim(),
                Sequencia_09 = detalhamento.SEQ9.Trim(),
                Guia_09 = detalhamento.GUIA9.Trim(),
                Despacho_09 = detalhamento.DESPACHO9.Trim(),


                Item_10 = detalhamento.ITEM10.Trim(),
                MatDig_10 = detalhamento.MATDIG10.Trim(),
                MatRec_10 = detalhamento.MATREC10.Trim(),
                OrgaoDeDestino_10 = detalhamento.ORGDEST10.Trim(),
                DataDoDespacho_10 = detalhamento.DATDESP10.Trim(),
                Sequencia_10 = detalhamento.SEQ10.Trim(),
                Guia_10 = detalhamento.GUIA10.Trim(),
                Despacho_10 = detalhamento.DESPACHO10.Trim(),

                Item_11 = detalhamento.ITEM11.Trim(),
                MatDig_11 = detalhamento.MATDIG11.Trim(),
                MatRec_11 = detalhamento.MATREC11.Trim(),
                OrgaoDeDestino_11 = detalhamento.ORGDEST11.Trim(),
                DataDoDespacho_11 = detalhamento.DATDESP11.Trim(),
                Sequencia_11 = detalhamento.SEQ11.Trim(),
                Guia_11 = detalhamento.GUIA11.Trim(),
                Despacho_11 = detalhamento.DESPACHO11.Trim(),

                Item_12 = detalhamento.ITEM12.Trim(),
                MatDig_12 = detalhamento.MATDIG12.Trim(),
                MatRec_12 = detalhamento.MATREC12.Trim(),
                OrgaoDeDestino_12 = detalhamento.ORGDEST12.Trim(),
                DataDoDespacho_12 = detalhamento.DATDESP12.Trim(),
                Sequencia_12 = detalhamento.SEQ12.Trim(),
                Guia_12 = detalhamento.GUIA12.Trim(),
                Despacho_12 = detalhamento.DESPACHO12.Trim(),

                Item_13 = detalhamento.ITEM13.Trim(),
                MatDig_13 = detalhamento.MATDIG13.Trim(),
                MatRec_13 = detalhamento.MATREC13.Trim(),
                OrgaoDeDestino_13 = detalhamento.ORGDEST13.Trim(),
                DataDoDespacho_13 = detalhamento.DATDESP13.Trim(),
                Sequencia_13 = detalhamento.SEQ13.Trim(),
                Guia_13 = detalhamento.GUIA13.Trim(),
                Despacho_13 = detalhamento.DESPACHO13.Trim(),

                Item_14 = detalhamento.ITEM14.Trim(),
                MatDig_14 = detalhamento.MATDIG14.Trim(),
                MatRec_14 = detalhamento.MATREC14.Trim(),
                OrgaoDeDestino_14 = detalhamento.ORGDEST14.Trim(),
                DataDoDespacho_14 = detalhamento.DATDESP14.Trim(),
                Sequencia_14 = detalhamento.SEQ14.Trim(),
                Guia_14 = detalhamento.GUIA14.Trim(),
                Despacho_14 = detalhamento.DESPACHO14.Trim(),

                Concad = detalhamento.CONCAD.Trim(),
                StatusLine = detalhamento.StatusLine == null ? "" : detalhamento.StatusLine.Trim()
            };
        }
    }
}
