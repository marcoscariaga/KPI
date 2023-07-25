using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Entidades
{
    public class Despacho : Base
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
