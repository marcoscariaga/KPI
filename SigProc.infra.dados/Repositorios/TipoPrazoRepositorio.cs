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
    public class TipoPrazoRepositorio : BaseRepositorio<TipoPrazo>, ITipoPrazoRepositorio
    {
        private readonly SqlServidorContexto contexto;
        public TipoPrazoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<TipoPrazo> ListarAtivos()
        {
            return contexto.TipoPrazo.Where(a => a.Status == true).ToList();
        }
    }
}