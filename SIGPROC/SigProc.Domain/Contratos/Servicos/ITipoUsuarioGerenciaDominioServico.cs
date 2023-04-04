using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface ITipoUsuarioGerenciaDominioServico : IBaseDominioServico<TipoUsuarioGerencia>
    {
        public ICollection<TipoUsuarioGerencia> ListarAtivos();
    }
}
