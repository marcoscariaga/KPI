﻿using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;


namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IProcessoTramitacaoDominioServico : IBaseDominioServico<ProcessoTramitacao>
    {
        public ICollection<ProcessoTramitacao> ListarAtivos();
        ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso);
        ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso);
    }
}
