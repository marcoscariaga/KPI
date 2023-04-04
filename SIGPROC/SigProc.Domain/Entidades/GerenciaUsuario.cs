using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class GerenciaUsuario : Base
    {
        public int IdGerencia { get; set; }
        public int IdUsuarioGerencia { get; set; }
        public int IdTipoUsuarioGerencia { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public virtual Gerencia Gerencia { get; set; }
        public virtual Usuario UsuarioGerencia { get; set; }
        public virtual Usuario UsuarioCadastro { get; set; }
        public virtual TipoUsuarioGerencia TipoUsuarioGerencia { get; set; }

    }
}
