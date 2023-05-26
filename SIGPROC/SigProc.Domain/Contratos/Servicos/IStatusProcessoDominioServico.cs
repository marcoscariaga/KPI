﻿using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Entidades;

namespace SigProc.Dominio.Contratos.Servicos
{
    public interface IStatusProcessoDominioServico : IBaseDominioServico<StatusProcesso>
    {
        public ICollection<StatusProcesso> ListarAtivos();
    }
}