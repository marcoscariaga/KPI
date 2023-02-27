using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface ITipoContratacaoDominioServico : IBaseDominioServico<TipoContratacao>
    {
        public ICollection<TipoContratacao> ListarAtivos();
    }
}
