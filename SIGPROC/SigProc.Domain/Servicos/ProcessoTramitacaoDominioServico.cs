using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoTramitacaoDominioServico : BaseDominioServico<ProcessoTramitacao>, IProcessoTramitacaoDominioServico
    {
        private readonly IProcessoTramitacaoRepositorio _repositorio;
        public ProcessoTramitacaoDominioServico(IProcessoTramitacaoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ProcessoTramitacao BuscarPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }

    }
}
