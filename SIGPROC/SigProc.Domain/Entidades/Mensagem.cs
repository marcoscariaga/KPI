using SigProc.Domain.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Entidades
{
    public class Mensagem : Base
    {
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }
        public int IdGerencia { get; set; }
        public int? IdTramitacao { get; set; }
        public int? IdProcesso { get; set; }
        public int? IdStatusProcesso { get; set; }

        public virtual ProcessoTramitacao ProcessoTramitacao { get; set; }
        public virtual Gerencia Gerencia{ get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
