using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
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
    public class GerenciaRepositorio : BaseRepositorio<Gerencia>, IGerenciaRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public GerenciaRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return contexto.Gerencia.Where(a => a.Status == true).ToList();
        }
        public Gerencia BuscarPorSiglaGerencia(string sigla)
            => contexto.Gerencia
                .AsNoTracking()
                .FirstOrDefault(x => x.Sigla.Equals(sigla));

        public void Salvar()
        {
            throw new NotImplementedException();
        }

        public Gerencia ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
