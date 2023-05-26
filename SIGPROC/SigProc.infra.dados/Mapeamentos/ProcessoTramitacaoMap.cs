using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Entidades;
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

            builder.HasOne<Gerencia>(c => c.GerenciaOrigem)
                 .WithMany()
                 .HasForeignKey(c => c.IdOrgaoOrigem)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Gerencia>(c => c.GerenciaDestino)
               .WithMany()
               .HasForeignKey(c => c.IdOrgaoDestino)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Processo>(c => c.Processo)
               .WithMany()
               .HasForeignKey(c => c.IdProcesso).IsRequired();

            builder.Property(c => c.MatriculaDigitador);
            builder.Property(c => c.NumeroProcesso);
            builder.Property(c => c.Despacho);

            builder.Property(c => c.Prazo).IsRequired();
            builder.Property(c => c.TempoPrazo);
            builder.Property(c => c.Guia);
            builder.Property(c => c.Sequencia);
            builder.Property(c => c.TempoEnvio);

            builder.Property(c => c.DataEnvio);
            builder.Property(c => c.DataRecebimento);
            builder.Property(c => c.DataTramitacao);
            builder.Property(c => c.DataPrazo).IsRequired();
         
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);

            builder.Property(c => c.Mensagem);
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);

        }
    }
}
