using ServiceSicop;
using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloEntrada;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class DadosDeTramitacaoSicopServico : BaseServico<DadosDeTramitacaoSicop>, IDadosDeTramitacaoSicopServico
    {
        private readonly IDadosDeTramitacaoSicopDominioServico dadosDeTramitacaoSicopDominioServico;

        public DadosDeTramitacaoSicopServico(IDadosDeTramitacaoSicopDominioServico dadosDeTramitacaoSicopDominioServico) : base(dadosDeTramitacaoSicopDominioServico)
        {
            this.dadosDeTramitacaoSicopDominioServico = dadosDeTramitacaoSicopDominioServico;
        }

        public DadosDeTramitacaoSicop ConsultarProcesso(string numeroProcesso)
        {
            return dadosDeTramitacaoSicopDominioServico.ConsultarProcesso(numeroProcesso);
        }
    }
}
