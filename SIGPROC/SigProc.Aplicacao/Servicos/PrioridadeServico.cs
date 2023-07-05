using SigProc.Aplicacao.Contratos;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class PrioridadeServico : BaseServico<Prioridade>, IPrioridadeServico
    {
        private readonly PrioridadeDominioServico _prioridadeDomainService;

        public PrioridadeServico(IPrioridadeDominioServico prioridadeDomainService) : base(prioridadeDomainService)
        {
            _prioridadeDomainService = prioridadeDomainService;
        }

        public ICollection<Prioridade> BuscarPrioridadePorIdProcesso(int idProcesso)
        {
            return _prioridadeDomainService.BuscaPrioridadePorIdProcesso(idProcesso);
        }

        public ICollection<Prioridade> BuscaPrioridadePorIdTramitacao(int idTramitacao)
        {
            return _prioridadeDomainService.BuscarPrioridadePorIdTramitacao(idTramitacao);
        }

        public Mensagem BuscarUltimaPrioridadePorIdProcesso(int id)
        {
            return _prioridadeDomainService.BuscarUltimaPrioridadePorIdProcesso(id);
        }

    }
}
