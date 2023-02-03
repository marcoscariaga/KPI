using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());

        }
    }
}
