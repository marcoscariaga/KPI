using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class TipoPrazoDominioServico : BaseDominioServico<TipoPrazo>, ITipoPrazoDominioServico
    {
        private readonly ITipoPrazoRepositorio _repositorio;
        public TipoPrazoDominioServico(ITipoPrazoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<TipoPrazo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
