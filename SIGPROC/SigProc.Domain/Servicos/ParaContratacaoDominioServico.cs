using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class ParaContratacaoDominioServico : BaseDominioServico<ParaContratacao>, IParaContratacaoDominioServico
    {
        private readonly IParaContratacaoRepositorio _repositorio;
        public ParaContratacaoDominioServico(IParaContratacaoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<ParaContratacao> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
