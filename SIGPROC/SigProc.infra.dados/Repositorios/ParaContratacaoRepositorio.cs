﻿using Microsoft.EntityFrameworkCore;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class ParaContratacaoRepositorio : BaseRepositorio<ParaContratacao>, IParaContratacaoRepositorio
    {
        private readonly SqlServidorContexto contexto;
        public ParaContratacaoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<ParaContratacao> ListarAtivos()
        {
            
        }
    }
}
