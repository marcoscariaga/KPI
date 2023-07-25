using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class TipoUsuarioGerenciaDominioServico : BaseDominioServico<TipoUsuarioGerencia>, ITipoUsuarioGerenciaDominioServico
    {
        private readonly ITipoUsuarioGerenciaRepositorio _repositorio;
        public TipoUsuarioGerenciaDominioServico(ITipoUsuarioGerenciaRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<TipoUsuarioGerencia> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
