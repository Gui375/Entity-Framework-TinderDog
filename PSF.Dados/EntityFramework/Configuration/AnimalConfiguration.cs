using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSF.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSF.Dados.EntityFramework.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(f => f.AniamlID);
            builder
                .Property(f => f.AniamlID)
                .HasColumnName("FuncionarioID")
                .HasColumnType("int");

            builder
                .Property(f => f.Raca)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");

            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder
                .Property(f => f.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("char(1)");


        }
    }
}
