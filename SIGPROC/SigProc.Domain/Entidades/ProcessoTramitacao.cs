using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
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
        public int? IdOrgaoOrigem { get; set; }
        public int? IdOrgaoDestino { get; set; }
       // public int? IdDespacho { get; set; }
        public int IdProcesso { get; set; }

        public string? MatriculaRecebedor { get; set; }
        public string? MatriculaDigitador { get; set; }
        public string NumeroProcesso { get; set; }
        public string? Despacho { get; set; }
        public string? Mensagem { get; set; }

        public int Prazo { get; set; }
        public int? TempoPrazo { get; set; }
        public int Guia { get; set; }
        public int Sequencia { get; set; }
        public int? TempoEnvio { get; set; }
        


        [Column(TypeName = "date")]
        public DateTime? DataEnvio { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataRecebimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataTramitacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataPrazo { get; set; }

        public virtual Processo Processo { get; set; }
        public virtual Gerencia GerenciaOrigem { get; set; }
        public virtual Gerencia GerenciaDestino { get; set; }
       // public virtual Despacho Despacho { get; set; }
    }
}
