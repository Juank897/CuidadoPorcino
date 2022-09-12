﻿// <auto-generated />
using System;
using CuidadoPorcino.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Cerdo", b =>
                {
                    b.Property<int>("IdCerdos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCerdos");

                    b.ToTable("Cerdos");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.ControlSignos", b =>
                {
                    b.Property<int>("IdControlSigno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoDeAnimo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrecuenciaCardiaca")
                        .HasColumnType("int");

                    b.Property<int>("FrecuenciaRespiratoria")
                        .HasColumnType("int");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<double>("Temperatura")
                        .HasColumnType("float");

                    b.Property<int?>("cerdoIdCerdos")
                        .HasColumnType("int");

                    b.HasKey("IdControlSigno");

                    b.HasIndex("cerdoIdCerdos");

                    b.ToTable("ControlSignos");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("IdHistoriaClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaApertura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cerdoIdCerdos")
                        .HasColumnType("int");

                    b.Property<int?>("recomendacionIdRecomendacion")
                        .HasColumnType("int");

                    b.HasKey("IdHistoriaClinica");

                    b.HasIndex("cerdoIdCerdos");

                    b.HasIndex("recomendacionIdRecomendacion");

                    b.ToTable("HistoriaClinicas");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPersona");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Propietario", b =>
                {
                    b.Property<int>("IdPropietario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("cerdoIdCerdos")
                        .HasColumnType("int");

                    b.Property<int?>("personaIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdPropietario");

                    b.HasIndex("cerdoIdCerdos");

                    b.HasIndex("personaIdPersona");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Recomendacion", b =>
                {
                    b.Property<int>("IdRecomendacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescripcionRecomendacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormulaMedicamentos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRecomendacion");

                    b.ToTable("Recomendaciones");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Veterinario", b =>
                {
                    b.Property<int>("IdVeterinario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TarjetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cerdoIdCerdos")
                        .HasColumnType("int");

                    b.Property<int?>("personaIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdVeterinario");

                    b.HasIndex("cerdoIdCerdos");

                    b.HasIndex("personaIdPersona");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.ControlSignos", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Cerdo", "cerdo")
                        .WithMany()
                        .HasForeignKey("cerdoIdCerdos");

                    b.Navigation("cerdo");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Cerdo", "cerdo")
                        .WithMany()
                        .HasForeignKey("cerdoIdCerdos");

                    b.HasOne("CuidadoPorcino.App.Dominio.Recomendacion", "recomendacion")
                        .WithMany()
                        .HasForeignKey("recomendacionIdRecomendacion");

                    b.Navigation("cerdo");

                    b.Navigation("recomendacion");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Propietario", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Cerdo", "cerdo")
                        .WithMany()
                        .HasForeignKey("cerdoIdCerdos");

                    b.HasOne("CuidadoPorcino.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaIdPersona");

                    b.Navigation("cerdo");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Veterinario", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Cerdo", "cerdo")
                        .WithMany()
                        .HasForeignKey("cerdoIdCerdos");

                    b.HasOne("CuidadoPorcino.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaIdPersona");

                    b.Navigation("cerdo");

                    b.Navigation("persona");
                });
#pragma warning restore 612, 618
        }
    }
}
