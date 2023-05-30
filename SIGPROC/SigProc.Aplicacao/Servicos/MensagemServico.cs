using SigProc.Aplicacao.Contratos;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class MensagemServico : BaseServico<Mensagem>, IMensagemServico
    {
        private readonly IMensagemDominioServico _mensagemDomainService;

        public MensagemServico(IMensagemDominioServico mensagemDomainService) : base(mensagemDomainService)
        {
            _mensagemDomainService = mensagemDomainService;
        }

        public ICollection<Mensagem> BuscarMensagemPorIdProcesso(int idProcesso)
        {
            return _mensagemDomainService.BuscarMensagemPorIdProcesso(idProcesso);
        }

        public ICollection<Mensagem> BuscarMensagemPorIdTramitacao(int idTramitacao)
        {
            return _mensagemDomainService.BuscarMensagemPorIdTramitacao(idTramitacao);
        }
    }
}
