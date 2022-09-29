using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.IdPropietario);
                    table.ForeignKey(
                        name: "FK_Propietarios_Personas_personaIdPersona",
                        column: x => x.personaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarios",
                columns: table => new
                {
                    IdVeterinario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personaIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarios", x => x.IdVeterinario);
                    table.ForeignKey(
                        name: "FK_Veterinarios_Personas_personaIdPersona",
                        column: x => x.personaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cerdos",
                columns: table => new
                {
                    IdCerdos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPropietario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cerdos", x => x.IdCerdos);
                    table.ForeignKey(
                        name: "FK_Cerdos_Propietarios_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "Propietarios",
                        principalColumn: "IdPropietario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaClinicas",
                columns: table => new
                {
                    IdHistoriaClinica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaApertura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cerdoIdCerdos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinicas", x => x.IdHistoriaClinica);
                    table.ForeignKey(
                        name: "FK_HistoriaClinicas_Cerdos_cerdoIdCerdos",
                        column: x => x.cerdoIdCerdos,
                        principalTable: "Cerdos",
                        principalColumn: "IdCerdos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlSignos",
                columns: table => new
                {
                    IdControlSigno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    EstadoDeAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionRecomendacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormulaMedicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    historiaClinicaIdHistoriaClinica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlSignos", x => x.IdControlSigno);
                    table.ForeignKey(
                        name: "FK_ControlSignos_HistoriaClinicas_historiaClinicaIdHistoriaClinica",
                        column: x => x.historiaClinicaIdHistoriaClinica,
                        principalTable: "HistoriaClinicas",
                        principalColumn: "IdHistoriaClinica",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cerdos_IdPropietario",
                table: "Cerdos",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_ControlSignos_historiaClinicaIdHistoriaClinica",
                table: "ControlSignos",
                column: "historiaClinicaIdHistoriaClinica");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_cerdoIdCerdos",
                table: "HistoriaClinicas",
                column: "cerdoIdCerdos");

            migrationBuilder.CreateIndex(
                name: "IX_Propietarios_personaIdPersona",
                table: "Propietarios",
                column: "personaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinarios_personaIdPersona",
                table: "Veterinarios",
                column: "personaIdPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlSignos");

            migrationBuilder.DropTable(
                name: "Veterinarios");

            migrationBuilder.DropTable(
                name: "HistoriaClinicas");

            migrationBuilder.DropTable(
                name: "Cerdos");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
