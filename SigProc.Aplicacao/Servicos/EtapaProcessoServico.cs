using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Servicos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class EtapaProcessoServico : BaseServico<EtapaProcesso>, IEtapaProcessoServico
    {
        private readonly IEtapaProcessoDominioServico etapaProcessoDomainService;
        public EtapaProcessoServico(IEtapaProcessoDominioServico etapaProcessoDomainService) : base(etapaProcessoDomainService)
        {
            this.etapaProcessoDomainService = etapaProcessoDomainService;
        }

        public ICollection<EtapaProcesso> ListarAtivos()
        {
            return etapaProcessoDomainService.ListarAtivos();
        }
    }

}
