using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IProcessoTramitacaoDominioServico : IBaseDominioServico<ProcessoTramitacao>
    {
        public ICollection<ProcessoTramitacao> ListarAtivos();
        ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia);
        ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario);
    }
}
