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
    public class GerenciaPrazoRepositorio : BaseRepositorio<GerenciaPrazo>, IGerenciaPrazoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public GerenciaPrazoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<GerenciaPrazo> ListarAtivos()
        {
            return contexto.GerenciaPrazo.Where(a => a.Status == true).ToList();
        }

        public ICollection<GerenciaPrazo> RetornaPorIdGerencia(int id_gerencia)
        {
            return contexto.GerenciaPrazo.Include(a => a.Gerencia).Include(a => a.TipoPrazo).Include(a => a.TipoContratacao).Include(a => a.TipoProcesso).Where(x => x.IdGerencia == id_gerencia).ToList();
        }
    }
}
