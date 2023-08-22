using SigProc.Domain.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class ProcessoUpdateModelo
    {
        public int? Id { get; set; }
        public string NumProcesso { get; set; }
        public string Requerente { get; set; }
        public string Assunto { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string DataCadastroProc { get; set; }
        public string DataUltimaTramProc { get; set; }
        public string OrgaoCadastro { get; set; }
        public string OrgaoOrigem { get; set; }
        public string OrgaoDestino { get; set; }
        public string InfoComplementar { get; set; }
        public string Prioridade { get; set; }

        //Alterar o nome IdTipoContratacao para IdTipoModalidade
        public int IdTipoContratacao { get; set; }
        public int IdInstrumentosAuxiliares { get; set; }
        public int IdParaContratacao { get; set; }
        public int IdTipoProcesso { get; set; }
        public string Observacao { get; set; }
        public int IdUsuarioCadastro { get; set; }

        //Alterar o nome IdStatusProcesso para IdEstadoProcesso
        public int IdStatusProcesso { get; set; }
        public bool Status { get; set; }
        

        //public string? Usuario  { get; set; }
        //public string? TipoContratacao { get; set; }
        //public string? TipoProcesso  { get; set; }
        //public string? StatusProcesso { get; set; }

    }
}

