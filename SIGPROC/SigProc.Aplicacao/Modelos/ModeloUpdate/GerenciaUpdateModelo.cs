using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class GerenciaUpdateModelo
    {
       
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public int Prazo { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public bool Status { get; set; }
    }
}
