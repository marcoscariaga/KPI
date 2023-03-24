using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domain.Entidades
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public bool Status { get; set; }
    }
}
