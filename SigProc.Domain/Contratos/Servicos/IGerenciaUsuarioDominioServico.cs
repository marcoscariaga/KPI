using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IGerenciaUsuarioDominioServico : IBaseDominioServico<GerenciaUsuario>
    {
        public ICollection<GerenciaUsuario> ListarAtivos();
        public ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia);
        public ICollection<GerenciaUsuario> ListarGerenciaPorIdUsuario(int idUsuario);


    }
}
