using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Entidades
{
    public class Feriado : Base
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataFeriado { get; set; }
    }
}
