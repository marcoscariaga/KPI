using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class StatusProcessoDominioServico : BaseDominioServico<StatusProcesso>, IStatusProcessoDominioServico
    {
        private readonly IStatusProcessoRepositorio _repositorio;
        public StatusProcessoDominioServico(IStatusProcessoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<StatusProcesso> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
