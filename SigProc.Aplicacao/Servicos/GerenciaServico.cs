using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class GerenciaServico : BaseServico<Gerencia>, IGerenciaServico
    {
        private readonly IGerenciaDominioServico gerenciaDomainService;
        public GerenciaServico(IGerenciaDominioServico gerenciaDomainService) : base(gerenciaDomainService)
        {
            this.gerenciaDomainService = gerenciaDomainService;
        }

        public ICollection<Gerencia> ListarAtivos()
        {
            return gerenciaDomainService.ListarAtivos();
        }


    }

}
