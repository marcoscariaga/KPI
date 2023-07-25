using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IParaContratacaoDominioServico : IBaseDominioServico<ParaContratacao>
    {
        public ICollection<ParaContratacao> ListarAtivos();
    }
}
