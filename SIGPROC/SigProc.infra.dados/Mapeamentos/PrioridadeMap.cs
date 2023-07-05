using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class PrioridadeMap : IEntityTypeConfiguration<Prioridade>
    {
        public void Configure(EntityTypeBuilder<Prioridade> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);

            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.IdProcesso); 
            builder.Property(c => c.IdStatusProcesso); 

            builder.HasOne<ProcessoTramitacao>(c => c.ProcessoTramitacao)
                .WithMany()
                .HasForeignKey(c => c.IdTramitacao).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Gerencia>(c => c.Gerencia)
                .WithMany()
                .HasForeignKey(c => c.IdGerencia).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Usuario>(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.IdUsuario).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
