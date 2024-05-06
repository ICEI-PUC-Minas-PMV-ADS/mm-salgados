﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMSalgados.Domain.Entities;

namespace MMSalgados.Infra.Data.EntitiesConfigurations
{
    public class PerfillUsuarioConfiguration : IEntityTypeConfiguration<PerfilUsuario>
    {
        public void Configure(EntityTypeBuilder<PerfilUsuario> builder)
        {
            builder.ToTable("PerfilUsuario");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(30).IsRequired();
            builder.Property(u => u.Situacao).IsRequired();

            builder.HasData(
                new PerfilUsuario()
                {
                    Id = 1,
                    Nome = "ADMIN",
                    Situacao = 1
                },
                new PerfilUsuario()
                {
                    Id = 2,
                    Nome = "CLIENTE",
                    Situacao = 1
                }
            );
        }
    }
}
