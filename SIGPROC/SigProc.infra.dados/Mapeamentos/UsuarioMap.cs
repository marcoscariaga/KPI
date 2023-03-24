using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Cpf).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Telefone).IsRequired();
            builder.Property(c => c.Matricula);
            builder.Property(c => c.DataNasc);
            builder.Property(c => c.Sexo);
            builder.Property(c => c.Senha).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
