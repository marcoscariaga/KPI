using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    public interface IPrioridadeServico : IBaseDominioServico<Prioridade>
    {
        ICollection<Prioridade> BuscarPrioridadePorIdTramitacao(int idTramitacao);
        ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso);
        Prioridade BuscarUltimaPrioridadePorIdProcesso(int id);
    }
}
