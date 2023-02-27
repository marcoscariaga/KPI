using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class TipoProcessoDominioServico : BaseDominioServico<TipoProcesso>, ITipoProcessoDominioServico
    {
        private readonly ITipoProcessoRepositorio _repositorio;
        public TipoProcessoDominioServico(ITipoProcessoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<TipoProcesso> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
