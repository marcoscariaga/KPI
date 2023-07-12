using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class InstrumentosAuxDominioServico : BaseDominioServico<InstrumentosAux>, IInstrumentosAuxDominioServico
    {
        private readonly IInstrumentosAuxRepositorio _repositorio;
        public InstrumentosAuxDominioServico(IInstrumentosAuxRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<InstrumentosAux> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
