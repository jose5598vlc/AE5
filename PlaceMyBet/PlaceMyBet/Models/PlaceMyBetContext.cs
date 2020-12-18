using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class PlaceMyBetContext : DbContext
    {

        public DbSet<Apuesta> Apuestas { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CBancaria> CBancaria { get; set; }

        public DbSet<EventosExamen> examen { get; set; }


        public PlaceMyBetContext()
        {

        }

        public PlaceMyBetContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=placemybet2;Uid=root;contraseña=;SslMode=none");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario(1,"email123@gmail.com","Illo", "Juan",26));
            modelBuilder.Entity<CBancaria>().HasData(new CBancaria(1,2599,"Santander","4599867523412345",1));
            modelBuilder.Entity<Evento>().HasData(new Evento(1,"FCBarcelona", "Real Madrid", "20/10/2020"));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1,1.5,1.43,2.85,100,50,1));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(1,true,1.5,100,"20/10/2020",1,"1"));

        }
    }

}