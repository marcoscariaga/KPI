using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoDominioServico : BaseDominioServico<Processo>, IProcessoDominioServico
    {
        private readonly IProcessoRepositorio _repositorio;
        public ProcessoDominioServico(IProcessoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<Processo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
