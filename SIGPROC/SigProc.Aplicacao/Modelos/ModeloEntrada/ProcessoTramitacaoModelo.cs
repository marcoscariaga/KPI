using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class ProcessoTramitacaoModelo
    {
        public int IdProcesso { get; set; }
        public int IdOrgaoOrigem { get; set; }
        public int IdOrgaoDestino { get; set; }
        public int? Prazo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Tramitacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Prazo { get; set; }
        public string Observacao { get; set; }
        public string NumeroProcesso { get; set; }
        public int IdUsuarioTramitacao { get; set; }
    }
}
