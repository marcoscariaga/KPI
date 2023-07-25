using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.infra.dados.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class DadosDoProcessoSicopRepositorio : BaseRepositorio<DadosDoProcessoSicop>, IDadosDoProcessoSicopRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public DadosDoProcessoSicopRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
    }
}
