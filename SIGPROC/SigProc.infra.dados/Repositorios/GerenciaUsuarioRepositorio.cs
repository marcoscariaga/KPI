using Microsoft.EntityFrameworkCore;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class GerenciaUsuarioRepositorio : BaseRepositorio<GerenciaUsuario>, IGerenciaUsuarioRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public GerenciaUsuarioRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<GerenciaUsuario> ListarAtivos()
        {
            return contexto.GerenciaUsuario.Where(a => a.Status == true).ToList();
        }

        public ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia)
        {
            return contexto.GerenciaUsuario.Include(a => a.Gerencia).Include(a => a.TipoUsuarioGerencia).Include(a => a.UsuarioGerencia).Include(a => a.UsuarioCadastro).Where(x => (x.IdGerencia == id_gerencia) && x.Status == true ).ToList();
        }
    }
}
