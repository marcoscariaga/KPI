using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Servicos
{

    public class EtapaProcessoDominioServico : BaseDominioServico<EtapaProcesso>, IEtapaProcessoDominioServico
    {
        private readonly IEtapaProcessoRepositorio _repositorio;
        public EtapaProcessoDominioServico(IEtapaProcessoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<EtapaProcesso> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
    }
}
