using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IGerenciaDominioServico : IBaseDominioServico<Gerencia>
    {
        public ICollection<Gerencia> ListarAtivos();
        public ICollection<Gerencia> Atualizar();
        Gerencia ObterPorId(object id);
    }
}
