using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IInstrumentosAuxDominioServico : IBaseDominioServico<InstrumentosAux>
    {
        public ICollection<InstrumentosAux> ListarAtivos();
    }
}
