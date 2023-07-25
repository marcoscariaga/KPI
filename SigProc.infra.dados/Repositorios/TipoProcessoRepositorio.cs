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
    public class TipoProcessoRepositorio : BaseRepositorio<TipoProcesso>, ITipoProcessoRepositorio
    {
        private readonly SqlServidorContexto contexto;
        public TipoProcessoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<TipoProcesso> ListarAtivos()
        {
            return contexto.TipoProcesso.Where(a => a.Status == true).ToList();
        }
    }
}
