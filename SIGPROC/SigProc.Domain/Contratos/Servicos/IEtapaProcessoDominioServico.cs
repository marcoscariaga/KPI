using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IEtapaProcessoDominioServico : IBaseDominioServico<EtapaProcesso>
    {
        public ICollection<EtapaProcesso> ListarAtivos();
    }
}
