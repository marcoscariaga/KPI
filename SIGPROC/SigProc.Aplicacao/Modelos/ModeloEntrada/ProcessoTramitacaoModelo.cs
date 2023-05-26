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
        public int IdTramitacao { get; set; }
        public string Mensagem { get; set; }
        //public string? IdOrgaoOrigem { get; set; }
        //public string? IdOrgaoDestino { get; set; }
        //public string? IdDespacho { get; set; }
        //public string? IdProcesso { get; set; }

        //public string? MatriculaDespacho { get; set; }
        //public string? MatriculaRecebedor { get; set; }
        //public string? MatriculaDigitador { get; set; }
        //public string? Endereco { get; set; }
        //public string? NumeroProcesso { get; set; }

        //public int Prazo { get; set; }
        //public int? TempoPrazo { get; set; }
        //public int Guia { get; set; }
        //public int Sequencia { get; set; }
        //public int? TempoEnvio { get; set; }


        //[Column(TypeName = "date")]
        //public DateTime? DataEnvio { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime? DataDigitacao { get; set; }
        //[Column(TypeName = "date")]
        //public DateTime? DataRecebimento { get; set; }

        //[Column(TypeName = "date")]
        //public DateTime? DataTramitacao { get; set; }

        //[Column(TypeName = "date")]
        //public DateTime? DataPrazo { get; set; }
    }
}
