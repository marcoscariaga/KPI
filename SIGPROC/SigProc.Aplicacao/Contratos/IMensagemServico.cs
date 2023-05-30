﻿using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Contratos
{
    public interface IMensagemServico : IBaseDominioServico<Mensagem>
    {
        ICollection<Mensagem> BuscarMensagemPorIdTramitacao(int idTramitacao);
        ICollection<Mensagem> BuscarMensagemPorIdProcesso(int idProcesso);
    }
}
