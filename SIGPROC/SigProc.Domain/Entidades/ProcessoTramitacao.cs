using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class ProcessoTramitacao : Base
    {
        
        public int IdProcesso { get; set; }
        public int IdOrgaoOrigem { get; set; }
        public int IdOrgaoDestino { get; set; }
        public int Prazo { get; set; }
        public int? TempoPrazo { get; set; }
        public int? TempoEnvio { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataEnvio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataTramitacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataPrazo { get; set; }
        public string Observacao { get; set; }
        public string NumeroProcesso { get; set; }
        public int IdUsuarioTramitacao { get; set; }


        public virtual Processo Processo { get; set; }
        public virtual Gerencia GerenciaOrigem { get; set; }
        public virtual Gerencia GerenciaDestino { get; set; }
        public virtual Usuario UsuarioTramitacao { get; set; }

    }
}
