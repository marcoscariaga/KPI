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
    public class TipoProcessoServico : BaseServico<TipoProcesso>, ITipoProcessoServico
    {
        private readonly ITipoProcessoDominioServico tipoProcessoDomainService;
        public TipoProcessoServico(ITipoProcessoDominioServico tipoProcessoDomainService) : base(tipoProcessoDomainService)
        {
            this.tipoProcessoDomainService = tipoProcessoDomainService;
        }

        public ICollection<TipoProcesso> ListarAtivos()
        {
            return tipoProcessoDomainService.ListarAtivos();
        }
    }

}
