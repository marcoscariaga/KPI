using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class GerenciaUsuarioDominioServico : BaseDominioServico<GerenciaUsuario>, IGerenciaUsuarioDominioServico
    {
        private readonly IGerenciaUsuarioRepositorio _repositorio;
        public GerenciaUsuarioDominioServico(IGerenciaUsuarioRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<GerenciaUsuario> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }

        public ICollection<GerenciaUsuario> RetornaPorIdGerencia(int id_gerencia)
        {
            return _repositorio.RetornaPorIdGerencia(id_gerencia);
        }

    }
}
