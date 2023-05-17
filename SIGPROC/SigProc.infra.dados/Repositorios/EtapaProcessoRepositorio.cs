using Microsoft.EntityFrameworkCore;
using SigProc.infra.dados.Repositorios;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.Infra.Seguranca.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SigProc.infra.dados.Repositorios
{
    public class EtapaProcessoRepositorio : BaseRepositorio<EtapaProcesso>, IEtapaProcessoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public EtapaProcessoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<EtapaProcesso> ListarAtivos()
        {
            return contexto.EtapaProcesso.Where(a => a.Status == true).ToList();
        }
    }
}
