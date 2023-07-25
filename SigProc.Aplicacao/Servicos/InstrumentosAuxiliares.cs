using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Servicos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class InstrumentosAuxiliaresServico : BaseServico<InstrumentosAuxiliares>, IInstrumentosAuxiliaresServico
    {
        private readonly IInstrumentosAuxiliaresDominioServico instrumentosAuxiliaresDomainService;
        public InstrumentosAuxiliaresServico(IInstrumentosAuxiliaresDominioServico instrumentosAuxiliaresDomainService) : base(instrumentosAuxiliaresDomainService)
        {
            this.instrumentosAuxiliaresDomainService = instrumentosAuxiliaresDomainService;
        }

        public ICollection<InstrumentosAuxiliares> ListarAtivos()
        {
            return instrumentosAuxiliaresDomainService.ListarAtivos();
        }
    }

}
