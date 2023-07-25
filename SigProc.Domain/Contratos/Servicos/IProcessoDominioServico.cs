using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IProcessoDominioServico : IBaseDominioServico<Processo>
    {
        public ICollection<Processo> ListarAtivos();
    }
}
