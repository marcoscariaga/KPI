using Microsoft.EntityFrameworkCore;
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
        public DbSet<GerenciaPrazo> GerenciaPrazo { get; set; }
        public DbSet<GerenciaUsuario> GerenciaUsuario { get; set; }
        public DbSet<Processo> Processo { get; set; }
        public DbSet<ProcessoTramitacao> ProcessoTramitacao { get; set; }
        public DbSet<TipoContratacao> TipoContratacao { get; set; }
        public DbSet<TipoProcesso> TipoProcesso { get; set; }
        public DbSet<EtapaProcesso> EtapaProcesso { get; set; }
        public DbSet<StatusProcesso> StatusProcesso { get; set; }
        public DbSet<TipoPrazo> TipoPrazo { get; set; }
        public DbSet<DadosDoProcessoSicop> DadosDoProcessoSicop { get; set; }
        public DbSet<DadosDeTramitacaoSicop> DadosDeTramitacaoSicop { get; set; }
        public DbSet<TipoUsuarioGerencia> TipoUsuarioGerencia { get; set; }
        public DbSet<Feriado> Feriado { get; set; }
        public DbSet<Despacho> Despacho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new GerenciaMap());
            modelBuilder.ApplyConfiguration(new GerenciaPrazoMap());
            modelBuilder.ApplyConfiguration(new GerenciaUsuarioMap());
            modelBuilder.ApplyConfiguration(new ProcessoMap());
            modelBuilder.ApplyConfiguration(new ProcessoTramitacaoMap());
            modelBuilder.ApplyConfiguration(new TipoContratacaoMap());
            modelBuilder.ApplyConfiguration(new TipoProcessoMap());
            modelBuilder.ApplyConfiguration(new StatusProcessoMap());
            modelBuilder.ApplyConfiguration(new TipoPrazoMap());
            modelBuilder.ApplyConfiguration(new TipoUsuarioGerenciaMap());
            modelBuilder.ApplyConfiguration(new DadosDoProcessoSicopMap());
            modelBuilder.ApplyConfiguration(new DadosDeTramitacaoSicopMap());
            modelBuilder.ApplyConfiguration(new FeriadoMap());
            modelBuilder.ApplyConfiguration(new DespachoMap());
            modelBuilder.ApplyConfiguration(new EtapaProcessoMap());
        }
    }
}
