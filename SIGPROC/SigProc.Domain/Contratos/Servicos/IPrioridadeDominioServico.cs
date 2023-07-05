using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Contratos.Servicos
{
    public interface IPrioridadeDominioServico : IBaseDominioServico<Prioridade>
    {
        ICollection<Prioridade> BuscarPrioridadePorIdTramitacao(int idTramitacao);
        ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso);
        public Prioridade BuscarUltimaPrioridadePorIdProcesso(int id);
    }
}
