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
    public class TipoPrazoServico : BaseServico<TipoPrazo>, ITipoPrazoServico
    {
        private readonly ITipoPrazoDominioServico tipoPrazoDomainService;
        public TipoPrazoServico(ITipoPrazoDominioServico tipoPrazoDomainService) : base(tipoPrazoDomainService)
        {
            this.tipoPrazoDomainService = tipoPrazoDomainService;
        }

        public ICollection<TipoPrazo> ListarAtivos()
        {
            return tipoPrazoDomainService.ListarAtivos();
        }
    }

}
