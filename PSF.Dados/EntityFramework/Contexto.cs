using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSF.Dominio.Entities;
using PSF.Dados.EntityFramework.Configuration;

namespace PSF.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        public DbSet<Animal> Animal { get; set; }

        public Contexto(DbContextOptionsBuilder options) : base(options.Options)
        {
            options.UseSqlServer(@"Data source = 201.62.57.93:1434; 
                                    Database = BD44748; 
                                    User ID = RA044748; 
                                    Password = 044748");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration()); 
        }
    }
}
