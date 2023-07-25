using SigProc.Aplicacao.Contratos;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class DespachoServico : BaseServico<Despacho>, IDespachoServico
    {
        private readonly IDespachoDominioServico despachoDomainService;
        public DespachoServico(IDespachoDominioServico despachoDomainService) : base(despachoDomainService)
        {
            this.despachoDomainService = despachoDomainService;
        }
    }
}
