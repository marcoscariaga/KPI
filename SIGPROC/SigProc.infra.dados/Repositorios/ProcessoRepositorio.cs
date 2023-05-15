using Microsoft.EntityFrameworkCore;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class ProcessoRepositorio : BaseRepositorio<Processo>, IProcessoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public ProcessoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public Processo BuscarPorNumeroProcesso(string numeroProcesso)
        {
            return contexto.Processo.Where(a => a.Status.Equals(true) && a.NumProcesso.Equals(numeroProcesso)).FirstOrDefault();
        }

        public ICollection<Processo> ListarAtivos()
        {
            var processo = contexto.Processo.Where(a => a.Status == true).ToList();

           // var lista = new List<Processo>();
            //foreach (var item in processo)
            //{
            //    var gerenciaOrigem = contexto.ProcessoTramitacao.OrderByDescending(x => x.DataCriacao).Include(a => a.GerenciaOrigem).AsNoTracking()
            //                        .FirstOrDefault(x => x.NumeroProcesso.Equals(item.NumProcesso));
            //    var model = new Processo();

            //    model.Id = item.Id;
            //    model.NumProcesso = item.NumProcesso;
            //    model.Requerente = item.Requerente;
            //    model.Assunto= item.Assunto;
            //    model.OrgaoOrigem = gerenciaOrigem.GerenciaOrigem.Sigla;
            //    lista.Add(model);
            //}
            return processo;
        }
        public ICollection<Processo> ListarTudo()
        {
            var processo = contexto.Processo.Where(a => a.Status == true).ToList();

            var lista = new List<Processo>();
            foreach (var item in processo)
            {
                var gerenciaOrigem = contexto.ProcessoTramitacao.OrderByDescending(x => x.DataCriacao).Include(a => a.GerenciaOrigem).AsNoTracking()
                                    .FirstOrDefault(x => x.NumeroProcesso.Equals(item.NumProcesso));
                var model = new Processo();

                model.Id = item.Id;
                model.NumProcesso = item.NumProcesso;
                model.Requerente = item.Requerente;
                model.Assunto = item.Assunto;
                model.OrgaoOrigem = gerenciaOrigem.GerenciaOrigem.Sigla;
                lista.Add(model);
            }
            return processo;
        }
    }
}
