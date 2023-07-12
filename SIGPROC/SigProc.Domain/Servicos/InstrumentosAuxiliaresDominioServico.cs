using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class InstrumentosAuxiliaresDominioServico : BaseDominioServico<InstrumentosAuxiliares>, IInstrumentosAuxiliaresDominioServico
    {
        private readonly IInstrumentosAuxiliaresRepositorio _repositorio;
        public InstrumentosAuxiliaresDominioServico(IInstrumentosAuxiliaresRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<InstrumentosAuxiliares> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
