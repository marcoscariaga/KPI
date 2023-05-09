using Microsoft.AspNetCore.Mvc;
using SigProc.Domain.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SigProc.Dominio.Servicos.ProcessoTramitacaoDominioServico;

namespace SigProc.Dominio.Contratos.Dados
{
    public interface IProcessoTramitacaoRepositorio : IBaseRepositorio<ProcessoTramitacao>
    {
        ICollection<ProcessoTramitacao> ListarAtivos();
        ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario);
        public (TimeSpan diasRestantes, DateTime dataFutura ) CalculaPrazo(DateTime dataTramitacao, int prazo);
        public (int diasUteisRestantes, int diasUteisAtraso) ContarDiasUteis(DateTime dataInicial, DateTime? dataFinal);
    }
}
