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
    public class ParaContratacaoServico : BaseServico<ParaContratacao>, IParaContratacaoServico
    {
        private readonly IParaContratacaoDominioServico paraContratacaoDomainService;
        public ParaContratacaoServico(IParaContratacaoDominioServico paraContratacaoDomainService) : base(paraContratacaoDomainService)
        {
            this.paraContratacaoDomainService = paraContratacaoDomainService;
        }

        public ICollection<ParaContratacao> ListarAtivos()
        {
            return paraContratacaoDomainService.ListarAtivos();
        }
    }

}
