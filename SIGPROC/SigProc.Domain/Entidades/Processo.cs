using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class Processo : Base
    {
        
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
        public int IdTipoContratacao { get; set; }
        public int IdTipoProcesso { get; set; }
        public string Observacao { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual TipoContratacao TipoContratacao { get; set; }
        public virtual TipoProcesso TipoProcesso { get; set; }

    }
}
