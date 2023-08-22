using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface ITipoContratacaoDominioServico : IBaseDominioServico<TipoContratacao>
    {
        //Alterar o nome da classe de ITipoContratacaoDominioServico para ITipoModalidadeDominiServico
        public ICollection<TipoContratacao> ListarAtivos();
    }
}
