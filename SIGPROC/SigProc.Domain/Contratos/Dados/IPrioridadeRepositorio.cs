using SigProc.Domain.Contratos.Dados;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Contratos.Dados
{
    public interface IPrioridadeRepositorio : IBaseRepositorio<Prioridade>
    {
        ICollection<Prioridade> BuscarPrioridadePorIdTramitacao(int idTramitacao);
        ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso);
        public Prioridade BuscarUltimaPrioridadePorIdProcesso(int id);
    }
}
