using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface ITipoPrazoDominioServico : IBaseDominioServico<TipoPrazo>
    {
        public ICollection<TipoPrazo> ListarAtivos();
    }
}
