using SigProc.Domain.Contratos.Dados;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Contratos.Dados
{
    public interface IMensagemRepositorio : IBaseRepositorio<Mensagem>
    {
        ICollection<Mensagem> BuscarMensagemPorIdTramitacao(int idTramitacao);
        ICollection<Mensagem> BuscarMensagemPorIdProcesso(int idProcesso);
        public Mensagem BuscarUltimaMensagemPorIdProcesso(int id);
    }
}
