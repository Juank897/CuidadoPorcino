// <auto-generated />
using System;
using CuidadoPorcino.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Cerdo", b =>
                {
                    b.Property<int>("IdCerdos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCerdos"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCerdos");

                    b.HasIndex("IdPropietario");

                    b.ToTable("Cerdos");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.ControlSignos", b =>
                {
                    b.Property<int>("IdControlSigno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdControlSigno"), 1L, 1);

                    b.Property<string>("DescripcionRecomendacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoDeAnimo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormulaMedicamentos")
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

                    b.Property<int>("historiaClinicaIdHistoriaClinica")
                        .HasColumnType("int");

                    b.HasKey("IdControlSigno");

                    b.HasIndex("historiaClinicaIdHistoriaClinica");

                    b.ToTable("ControlSignos");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("IdHistoriaClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHistoriaClinica"), 1L, 1);

                    b.Property<string>("FechaApertura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cerdoIdCerdos")
                        .HasColumnType("int");

                    b.HasKey("IdHistoriaClinica");

                    b.HasIndex("cerdoIdCerdos");

                    b.ToTable("HistoriaClinicas");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
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
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPropietario"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personaIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdPropietario");

                    b.HasIndex("personaIdPersona");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Veterinario", b =>
                {
                    b.Property<int>("IdVeterinario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVeterinario"), 1L, 1);

                    b.Property<string>("TarjetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personaIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdVeterinario");

                    b.HasIndex("personaIdPersona");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Cerdo", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Propietario", "propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("propietario");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.ControlSignos", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.HistoriaClinica", "historiaClinica")
                        .WithMany()
                        .HasForeignKey("historiaClinicaIdHistoriaClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("historiaClinica");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Cerdo", "cerdo")
                        .WithMany()
                        .HasForeignKey("cerdoIdCerdos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cerdo");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Propietario", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("persona");
                });

            modelBuilder.Entity("CuidadoPorcino.App.Dominio.Veterinario", b =>
                {
                    b.HasOne("CuidadoPorcino.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("persona");
                });
#pragma warning restore 612, 618
        }
    }
}
