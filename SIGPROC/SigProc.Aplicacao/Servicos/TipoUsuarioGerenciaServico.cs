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
    public class TipoUsuarioGerenciaServico : BaseServico<TipoUsuarioGerencia>, ITipoUsuarioGerenciaServico
    {
        private readonly ITipoUsuarioGerenciaDominioServico tipoUsuarioGerenciaDomainService;
        public TipoUsuarioGerenciaServico(ITipoUsuarioGerenciaDominioServico tipoUsuarioGerenciaDomainService) : base(tipoUsuarioGerenciaDomainService)
        {
            this.tipoUsuarioGerenciaDomainService = tipoUsuarioGerenciaDomainService;
        }

        public ICollection<TipoUsuarioGerencia> ListarAtivos()
        {
            return tipoUsuarioGerenciaDomainService.ListarAtivos();
        }
    }

}
