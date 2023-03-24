using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Contratos.Dados;
using SigProc.infra.dados.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly SqlServidorContexto _ctx;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepositorio(SqlServidorContexto ctx)
        {
            _ctx = ctx;
            _dbSet = ctx.Set<TEntity>();
        }

        public TEntity Atualizar(TEntity objeto)
        {
            using var trans = _ctx.Database.BeginTransaction();
            try
            {
                _ctx.Entry(objeto).Property("DataEdicao").CurrentValue = DateTime.Now;
                _ctx.Entry(objeto).State = EntityState.Modified;
                _ctx.SaveChanges();

                trans.Commit();
                return objeto;
            }
            catch (Exception err)
            {
                trans.Rollback();
                throw err;
            }

        }

        public void Dispose()
        {
            _ctx.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity Excluir(int id)
        {
            using var trans = _ctx.Database.BeginTransaction();
            try
            {
                var objeto = _dbSet.Find(id); 
                _ctx.Entry(objeto).Property("DataExclusao").CurrentValue = DateTime.Now;
                _ctx.Entry(objeto).Property("Status").CurrentValue = false;
                _ctx.Entry(objeto).State = EntityState.Modified;
                _ctx.SaveChanges();

                trans.Commit();
                return objeto;
            }
            catch (Exception err)
            {
                trans.Rollback();
                throw err;
            }
        }

        public TEntity Inserir(TEntity objeto)
        {
            using var trans = _ctx.Database.BeginTransaction();
            try
            {
                _ctx.Entry(objeto).State = EntityState.Added;
                _ctx.Entry(objeto).Property("DataCriacao").CurrentValue = DateTime.Now;
                _ctx.SaveChanges();
                trans.Commit();

                return objeto;
            }
            catch (Exception err)
            {
                trans.Rollback();
                throw err;
            }
        }

        public ICollection<TEntity> ListarTudo()
        {
            return _dbSet.ToList();
        }

        public TEntity RetornaPorId(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
