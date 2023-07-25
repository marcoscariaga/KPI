using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Contratos.Servicos
{
    public interface ITipoProcessoDominioServico : IBaseDominioServico<TipoProcesso>
    {
        public ICollection<TipoProcesso> ListarAtivos();
    }
}
