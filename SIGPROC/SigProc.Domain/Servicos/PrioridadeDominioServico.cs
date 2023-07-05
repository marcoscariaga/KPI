using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class PrioridadeDominioServico : BaseDominioServico<Prioridade>, IPrioridadeDominioServico
    {
        private readonly IPrioridadeRepositorio _repositorio;
        public PrioridadeDominioServico(IPrioridadeRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso)
        {
            return _repositorio.BuscarPrioridadePorIdProcesso(idProcesso);
        }

        public ICollection<Prioridade> BuscarPrioridadePorIdTramitacao(int idTramitacao)
        {
            return _repositorio.BuscarPrioridadePorIdTramitacao(idTramitacao);
        }

        public Prioridade BuscarUltimaPrioridadePorIdProcesso(int id)
        {
            return _repositorio.BuscarUltimaPrioridadePorIdProcesso(id);
        }
    }
}
