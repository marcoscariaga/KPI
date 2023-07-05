using Microsoft.EntityFrameworkCore;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class PrioridadeRepositorio : BaseRepositorio<Prioridade>, IPrioridadeRepositorio
    {
        private readonly SqlServidorContexto contexto;
        public PrioridadeRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso)
        {
            //return contexto.Mensagem.Where(a => a.IdProcesso.Equals(idProcesso) && a.IdStatusProcesso != null).Include(x=>x.Gerencia).Include(x => x.Usuario).ToList();
        }
        public ICollection<Prioridade> BuscarPrioridadePorIdTramitacao(int idTramitacao)
        {
            //return contexto.Mensagem.Where(a => a.IdTramitacao.Equals(idTramitacao)).Include(x => x.Gerencia).Include(x => x.Usuario).ToList();
        }
        public Mensagem BuscarUltimaPrioridadePorIdProcesso(int id)
        {
            return contexto.Mensagem
                .Where(a => a.IdProcesso.Equals(id))
                .Include(x => x.Gerencia)
                .Include(x => x.ProcessoTramitacao)
                .Include(x => x.ProcessoTramitacao.EtapaProcesso)
                .OrderByDescending(x => x.DataCriacao)
                .FirstOrDefault();
        }

        Prioridade IPrioridadeRepositorio.BuscarUltimaPrioridadePorIdProcesso(int id)
        {
            throw new NotImplementedException();
        }
    }
}
