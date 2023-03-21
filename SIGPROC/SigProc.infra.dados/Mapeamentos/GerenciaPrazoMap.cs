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
    public class GerenciaPrazoMap : IEntityTypeConfiguration<GerenciaPrazo>
    {
        public void Configure(EntityTypeBuilder<GerenciaPrazo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne<Gerencia>(c => c.Gerencia)
               .WithMany()
               .HasForeignKey(c => c.IdGerencia).IsRequired();
            builder.HasOne<TipoPrazo>(c => c.TipoPrazo)
               .WithMany()
               .HasForeignKey(c => c.IdTipoPrazo).IsRequired();
            builder.HasOne<TipoContratacao>(c => c.TipoContratacao)
               .WithMany()
               .HasForeignKey(c => c.IdTipoContratacao);
            builder.HasOne<TipoProcesso>(c => c.TipoProcesso)
               .WithMany()
               .HasForeignKey(c => c.IdTipoProcesso);
            builder.Property(c => c.Prazo).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.IdUsuarioCadastro);
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);


        }
    }
}
