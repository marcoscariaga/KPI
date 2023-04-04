using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Modelos
{
    public class GerenciaUsuarioModelo
    {
        public int IdGerencia { get; set; }
        public int IdUsuarioGerencia { get; set; }
        public int IdTipoUsuarioGerencia { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public bool Status { get; set; }

    }
}
