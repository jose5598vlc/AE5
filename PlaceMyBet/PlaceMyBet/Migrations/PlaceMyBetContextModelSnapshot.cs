﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaceMyBet.Models;

namespace PlaceMyBet.Migrations
{
    [DbContext(typeof(PlaceMyBetContext))]
    partial class PlaceMyBetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
                {
                    b.Property<int>("ApuestaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MercadoId");

                    b.Property<string>("UsuarioId");

                    b.Property<double>("cuota");

                    b.Property<double>("dineroApostado");

                    b.Property<string>("fecha");

                    b.Property<bool>("tipoApuesta");

                    b.HasKey("ApuestaId");

                    b.HasIndex("MercadoId");

                    b.ToTable("Apuestas");

                    b.HasData(
                        new
                        {
                            ApuestaId = 1,
                            MercadoId = 1,
                            UsuarioId = "1",
                            cuota = 1.5,
                            dineroApostado = 100.0,
                            fecha = "20/10/2020",
                            tipoApuesta = true
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.CBancaria", b =>
                {
                    b.Property<int>("CBancariaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioId");

                    b.Property<string>("nombreBanco");

                    b.Property<string>("numtarCredito");

                    b.Property<double>("saldoBanco");

                    b.HasKey("CBancariaId");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("CBancaria");

                    b.HasData(
                        new
                        {
                            CBancariaId = 1,
                            UsuarioId = 1,
                            nombreBanco = "Santander",
                            numtarCredito = "4599867523412345",
                            saldoBanco = 2599.0
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("equipoLocal");

                    b.Property<string>("equipoVisitante");

                    b.Property<string>("fecha");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");

                    b.HasData(
                        new
                        {
                            EventoId = 1,
                            equipoLocal = "FCBarcelona",
                            equipoVisitante = "Real Madrid",
                            fecha = "20/10/2020"
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Mercado", b =>
                {
                    b.Property<int>("MercadoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventoId");

                    b.Property<double>("dineroapostadoOver");

                    b.Property<double>("dineroapostadoUnder");

                    b.Property<double>("infocuotaOver");

                    b.Property<double>("infocuotaUnder");

                    b.Property<double>("tipoMercado");

                    b.HasKey("MercadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Mercados");

                    b.HasData(
                        new
                        {
                            MercadoId = 1,
                            EventoId = 1,
                            dineroapostadoOver = 100.0,
                            dineroapostadoUnder = 50.0,
                            infocuotaOver = 1.4299999999999999,
                            infocuotaUnder = 2.8500000000000001,
                            tipoMercado = 1.5
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<int>("Edad");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellidos = "Juan",
                            Edad = 26,
                            Email = "email123@gmail.com",
                            Nombre = "Illo"
                        });
                });

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Mercado", "Mercados")
                        .WithMany("Apuestas")
                        .HasForeignKey("MercadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlaceMyBet.Models.CBancaria", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Usuario", "Usuario")
                        .WithOne("CBancaria")
                        .HasForeignKey("PlaceMyBet.Models.CBancaria", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlaceMyBet.Models.Mercado", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Evento", "Evento")
                        .WithMany("Mercados")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
