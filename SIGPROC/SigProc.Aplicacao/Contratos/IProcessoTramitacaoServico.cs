using SigProc.Aplicacao.Modelos.ModeloSaida;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SigProc.Dominio.Servicos.ProcessoTramitacaoDominioServico;

namespace SigProc.Aplicacao.Contratos
{
    public interface IProcessoTramitacaoServico : IBaseDominioServico<ProcessoTramitacao>
    {
        public ICollection<ProcessoTramitacao> ListarAtivos();
        ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario);
        public DadosDeTramitacao Testando(DadosDeTramitacaoSicop processoTramitacao);
        ICollection<ProcessoTramitacao>  Verificar(ProcessoTramitacao processoTramitacao);
    }
}
