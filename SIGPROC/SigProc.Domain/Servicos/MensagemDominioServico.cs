using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class MensagemDominioServico : BaseDominioServico<Mensagem>, IMensagemDominioServico
    {
        private readonly IMensagemRepositorio _repositorio;
        public MensagemDominioServico(IMensagemRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }

        public ICollection<Mensagem> BuscarMensagemPorIdProcesso(int idProcesso)
        {
            return _repositorio.BuscarMensagemPorIdProcesso(idProcesso);
        }

        public ICollection<Mensagem> BuscarMensagemPorIdTramitacao(int idTramitacao)
        {
            return _repositorio.BuscarMensagemPorIdTramitacao(idTramitacao);
        }

        public Mensagem BuscarUltimaMensagemPorIdProcesso(int id)
        {
            return _repositorio.BuscarUltimaMensagemPorIdProcesso(id);
        }
    }
}
