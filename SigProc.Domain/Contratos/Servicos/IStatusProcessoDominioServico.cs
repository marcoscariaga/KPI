using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IStatusProcessoDominioServico : IBaseDominioServico<StatusProcesso>
    {

        //Alterar o nome da classe de IStatusProcessoDominiServico para IEstadoProcessoDominioServico
        public ICollection<StatusProcesso> ListarAtivos();
    }
}
