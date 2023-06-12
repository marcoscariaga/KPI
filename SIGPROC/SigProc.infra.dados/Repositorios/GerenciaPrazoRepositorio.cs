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
            return contexto.GerenciaPrazo.Where(a => a.Status == true).Include(x=>x.EtapaProcesso).ToList();
        }

        public ICollection<GerenciaPrazo> RetornaPorIdGerencia(int id_gerencia)
        {
            return contexto.GerenciaPrazo.Include(a => a.Gerencia).Include(a => a.TipoPrazo).Include(a => a.TipoContratacao).Include(a => a.TipoProcesso).Include(a => a.EtapaProcesso).Where(x => (x.IdGerencia == id_gerencia) && x.Status == true ).ToList();
        }
        public GerenciaPrazo Inserir(GerenciaPrazo objeto)
        {
            if (objeto.IdTipoContratacao != null || objeto.IdEtapaProcesso != null || objeto.IdTipoProcesso != null)
            {
                var verifica = contexto.GerenciaPrazo
                    .AsNoTracking()
                    .Where(x => x.Status == true && x.IdGerencia.Equals(objeto.IdGerencia))
                    .FirstOrDefault(x =>
                        (objeto.IdTipoContratacao != null && x.IdTipoContratacao.Equals(objeto.IdTipoContratacao)) ||
                        (objeto.IdEtapaProcesso != null && x.IdEtapaProcesso.Equals(objeto.IdEtapaProcesso)) ||
                        (objeto.IdTipoProcesso != null && x.IdTipoProcesso.Equals(objeto.IdTipoProcesso))
                    );

                if (verifica != null)
                {
                    throw new ArgumentException("Esse prazo já cadastrado nessa gerência!");
                }
            }
            else
            {
                var verifica = contexto.GerenciaPrazo
                    .AsNoTracking()
                    .Where(x => x.Status == true && x.IdGerencia.Equals(objeto.IdGerencia))
                    .FirstOrDefault(x =>
                    (objeto.IdTipoPrazo != null && x.IdTipoPrazo.Equals(objeto.IdTipoPrazo))
                    );
                if (verifica != null)
                {
                    throw new ArgumentException("Esse prazo já cadastrado nessa gerência!");
                }
            }

            //var tipoProcesso = contexto.GerenciaPrazo.AsNoTracking().FirstOrDefault(x => x.IdTipoProcesso.Equals(objeto.IdTipoProcesso) && x.IdGerencia.Equals(objeto.IdGerencia));
            //if (tipoProcesso != null)
            //    throw new ArgumentException("Tipo de processo já cadastrado nessa gerência!");

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
    }
}
