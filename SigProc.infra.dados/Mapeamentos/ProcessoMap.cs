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
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NumProcesso).IsRequired();
            builder.Property(c => c.Requerente);
            builder.Property(c => c.Assunto);
            builder.Property(c => c.TipoDoc);
            builder.Property(c => c.NumDoc);
            builder.Property(c => c.DataCadastroProc);
            builder.Property(c => c.DataUltimaTramProc);
            builder.Property(c => c.OrgaoCadastro);
            builder.Property(c => c.OrgaoOrigem);
            builder.Property(c => c.OrgaoDestino);
            builder.Property(c => c.InfoComplementar);
            builder.Property(c => c.Prioridade);
            builder.Property(c => c.Observacao);
            builder.HasOne<TipoContratacao>(c => c.TipoContratacao)
                .WithMany()
                .HasForeignKey(c => c.IdTipoContratacao);
            builder.HasOne<TipoProcesso>(c => c.TipoProcesso)
                .WithMany()
                .HasForeignKey(c => c.IdTipoProcesso);
            builder.HasOne<StatusProcesso>(c => c.StatusProcesso)
                .WithMany()
                .HasForeignKey(c => c.IdStatusProcesso);
            builder.HasOne<Usuario>(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.IdUsuarioCadastro);
            builder.HasOne<InstrumentosAuxiliares>(c => c.InstrumentosAuxiliares)
                .WithMany()
                .HasForeignKey(c => c.IdInstrumentosAuxiliares);
            builder.HasOne<ParaContratacao>(c => c.ParaContratacao)
                .WithMany()
                .HasForeignKey(c => c.IdParaContratacao);
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);


        }
    }
}
