using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    public interface IDadosDeTramitacaoSicopServico : IBaseDominioServico<DadosDeTramitacaoSicop>
    {
        DadosDeTramitacaoSicop ConsultarProcesso(string numeroProcesso);
    }
}
