using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Contratos.Servicos
{
    public interface IDadosDeTramitacaoSicopDominioServico : IBaseDominioServico<DadosDeTramitacaoSicop>
    {
        public DadosDeTramitacaoSicop ConsultarProcesso(string numeroProcesso);
    }
}
