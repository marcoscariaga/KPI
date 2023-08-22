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

    //Alterar o nome StatusProcesso para EstadoProcesso
    public class StatusProcessoServico : BaseServico<StatusProcesso>, IStatusProcessoServico
    {
        private readonly IStatusProcessoDominioServico statusProcessoDomainService;
        public StatusProcessoServico(IStatusProcessoDominioServico statusProcessoDomainService) : base(statusProcessoDomainService)
        {
            this.statusProcessoDomainService = statusProcessoDomainService;
        }

        public ICollection<StatusProcesso> ListarAtivos()
        {
            return statusProcessoDomainService.ListarAtivos();
        }
    }

}
