using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class TipoContratacaoDominioServico : BaseDominioServico<TipoContratacao>, ITipoContratacaoDominioServico
    {
        private readonly ITipoContratacaoRepositorio _repositorio;
        public TipoContratacaoDominioServico(ITipoContratacaoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<TipoContratacao> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
