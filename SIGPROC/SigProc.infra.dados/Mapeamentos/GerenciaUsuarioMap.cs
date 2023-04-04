﻿using Microsoft.EntityFrameworkCore;
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
    public class GerenciaUsuarioMap : IEntityTypeConfiguration<GerenciaUsuario>
    {
        public void Configure(EntityTypeBuilder<GerenciaUsuario> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne<Gerencia>(c => c.Gerencia)
               .WithMany()
               .HasForeignKey(c => c.IdGerencia)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<TipoUsuarioGerencia>(c => c.TipoUsuarioGerencia)
               .WithMany()
               .HasForeignKey(c => c.IdTipoUsuarioGerencia)
               .IsRequired()
               .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Usuario>(c => c.UsuarioGerencia)
               .WithMany()
               .HasForeignKey(c => c.IdUsuarioGerencia)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Usuario>(c => c.UsuarioCadastro)
               .WithMany()
               .HasForeignKey(c => c.IdUsuarioCadastro)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);


            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.DataCriacao);
            builder.Property(c => c.DataExclusao);
            builder.Property(c => c.DataEdicao);
        }
    }
}