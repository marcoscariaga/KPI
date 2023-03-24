using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Domimio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class DadosDoProcessoSicopMap : IEntityTypeConfiguration<DadosDoProcessoSicop>
    {
        public void Configure(EntityTypeBuilder<DadosDoProcessoSicop> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
