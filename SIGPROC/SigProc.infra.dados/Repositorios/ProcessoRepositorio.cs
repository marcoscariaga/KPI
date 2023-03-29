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
            return contexto.Processo.Where(a => a.Status == true).ToList();
        }
    }
}
