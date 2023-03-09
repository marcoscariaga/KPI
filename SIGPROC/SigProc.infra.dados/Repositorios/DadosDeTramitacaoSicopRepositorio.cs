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
    public class DadosDeTramitacaoSicopRepositorio : BaseRepositorio<DadosDeTramitacaoSicop>, IDadosDeTramitacaoSicopRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public DadosDeTramitacaoSicopRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
    }
}
