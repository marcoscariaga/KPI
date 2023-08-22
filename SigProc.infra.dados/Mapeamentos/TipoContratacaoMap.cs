using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class TipoContratacaoMap : IEntityTypeConfiguration<TipoContratacao>
    {
        //Alterar o nome da classe para TipoModalidade
        public void Configure(EntityTypeBuilder<TipoContratacao> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
        }
    }
}
