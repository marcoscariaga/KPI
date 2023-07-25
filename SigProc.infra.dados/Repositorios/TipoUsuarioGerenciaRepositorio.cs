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
    public class TipoUsuarioGerenciaRepositorio : BaseRepositorio<TipoUsuarioGerencia>, ITipoUsuarioGerenciaRepositorio
    {
        private readonly SqlServidorContexto contexto;
        public TipoUsuarioGerenciaRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<TipoUsuarioGerencia> ListarAtivos()
        {
            return contexto.TipoUsuarioGerencia.Where(a => a.Status == true).ToList();
        }
    }
}
