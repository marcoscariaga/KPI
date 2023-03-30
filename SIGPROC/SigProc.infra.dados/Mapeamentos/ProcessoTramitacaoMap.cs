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
    public class ProcessoTramitacaoMap : IEntityTypeConfiguration<ProcessoTramitacao>
    {
        public void Configure(EntityTypeBuilder<ProcessoTramitacao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne<Processo>(c => c.Processo)
               .WithMany()
               .HasForeignKey(c => c.IdProcesso).IsRequired();


            builder.HasOne<Gerencia>(c => c.GerenciaOrigem)
               .WithMany()
               .HasForeignKey(c => c.IdOrgaoOrigem).IsRequired();

            builder.HasOne<Gerencia>(c => c.GerenciaDestino)
               .WithMany()
               .HasForeignKey(c => c.IdOrgaoDestino).IsRequired();

            builder.Property(c => c.Prazo).IsRequired();
            builder.Property(c => c.DataTramitacao).IsRequired();
            builder.Property(c => c.DataPrazo).IsRequired();
            builder.Property(c => c.Observacao);
            builder.Property(c => c.NumeroProcesso);
            builder.HasOne<Usuario>(c => c.UsuarioTramitacao)
               .WithMany()
               .HasForeignKey(c => c.IdUsuarioTramitacao)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);


        }
    }
}
