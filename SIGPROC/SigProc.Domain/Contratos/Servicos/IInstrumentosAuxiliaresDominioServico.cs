using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IInstrumentosAuxiliaresDominioServico : IBaseDominioServico<InstrumentosAuxiliares>
    {
        public ICollection<InstrumentosAuxiliares> ListarAtivos();
    }
}
