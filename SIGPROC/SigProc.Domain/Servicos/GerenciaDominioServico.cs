using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class GerenciaDominioServico : BaseDominioServico<Gerencia>, IGerenciaDominioServico
    {
        private readonly IGerenciaRepositorio _repositorio;
        public GerenciaDominioServico(IGerenciaRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
