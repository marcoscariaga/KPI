﻿using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Contextos
{
    public class SqlServidorContexto : DbContext
    {
        public SqlServidorContexto(DbContextOptions<SqlServidorContexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Gerencia> Gerencia { get; set; }
        public DbSet<TipoContratacao> TipoContratacao { get; set; }
        public DbSet<TipoProcesso> TipoProcesso { get; set; }
        public DbSet<DadosDoProcessoSicop> DadosDoProcessoSicop { get; set; }
        public DbSet<DadosDeTramitacaoSicop> DadosDeTramitacaoSicop { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new GerenciaMap());
            modelBuilder.ApplyConfiguration(new TipoContratacaoMap());
            modelBuilder.ApplyConfiguration(new TipoProcessoMap());
            modelBuilder.ApplyConfiguration(new DadosDoProcessoSicopMap());
            modelBuilder.ApplyConfiguration(new DadosDeTramitacaoSicopMap());
        }
    }
}
