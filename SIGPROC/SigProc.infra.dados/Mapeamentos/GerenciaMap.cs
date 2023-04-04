using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class GerenciaMap : IEntityTypeConfiguration<Gerencia>
    {
        public void Configure(EntityTypeBuilder<Gerencia> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.Sigla).IsRequired();
            builder.Property(c => c.Email);
            builder.Property(c => c.Telefone);
            builder.Property(c => c.Prazo);
            builder.HasOne<Usuario>(c => c.Usuario)
               .WithMany()
               .HasForeignKey(c => c.IdUsuarioResp).OnDelete(DeleteBehavior.Restrict);
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
        }
    }
}
