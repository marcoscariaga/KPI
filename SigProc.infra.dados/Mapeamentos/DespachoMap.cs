using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SigProc.Domimio.Entidades;

namespace SigProc.infra.dados.Mapeamentos
{
    public class DespachoMap : IEntityTypeConfiguration<Despacho>
    {
        public void Configure(EntityTypeBuilder<Despacho> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao);
            builder.Property(c => c.Codigo);
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
