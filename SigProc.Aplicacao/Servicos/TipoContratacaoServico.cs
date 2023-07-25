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
    public class TipoContratacaoServico : BaseServico<TipoContratacao>, ITipoContratacaoServico
    {
        private readonly ITipoContratacaoDominioServico tipoContratacaoDomainService;
        public TipoContratacaoServico(ITipoContratacaoDominioServico tipoContratacaoDomainService) : base(tipoContratacaoDomainService)
        {
            this.tipoContratacaoDomainService = tipoContratacaoDomainService;
        }

        public ICollection<TipoContratacao> ListarAtivos()
        {
            return tipoContratacaoDomainService.ListarAtivos();
        }
    }

}
