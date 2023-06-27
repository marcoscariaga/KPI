using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IGerenciaDominioServico : IBaseDominioServico<Gerencia>
    {
        public ICollection<Gerencia> ListarAtivos();
        //Gerencia RetornaPorId(object id);
    }
}
