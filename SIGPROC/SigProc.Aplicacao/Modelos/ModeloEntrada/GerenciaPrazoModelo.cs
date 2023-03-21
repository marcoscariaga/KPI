using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class GerenciaPrazoModelo
    {
        public int IdGerencia { get; set; }
        public int IdTipoPrazo { get; set; }
        public int? IdTipoContratacao { get; set; }
        public int? IdTipoProcesso { get; set; }
        public int Prazo { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public bool Status { get; set; }
    }
}
