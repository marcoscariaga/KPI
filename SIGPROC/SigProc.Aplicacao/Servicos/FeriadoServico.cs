using SigProc.Aplicacao.Contratos;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class FeriadoServico : BaseServico<Feriado>, IFeriadoServico
    {
        private readonly IFeriadoDominioServico feriadoDomainService;

        public FeriadoServico(IFeriadoDominioServico feriadoDomainService) : base(feriadoDomainService) 
        {
            this.feriadoDomainService = feriadoDomainService;
        }
    }
}