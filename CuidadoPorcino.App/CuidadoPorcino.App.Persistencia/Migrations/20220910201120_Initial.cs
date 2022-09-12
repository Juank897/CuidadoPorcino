using Microsoft.EntityFrameworkCore.Migrations;

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Propietarios_propietarioIdPropietario",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Veterinarios_veterinarioIdVeterinario",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_propietarioIdPropietario",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_veterinarioIdVeterinario",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "propietarioIdPropietario",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "veterinarioIdVeterinario",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "cerdoIdCerdos",
                table: "Veterinarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personaIdPersona",
                table: "Veterinarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cerdoIdCerdos",
                table: "Propietarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personaIdPersona",
                table: "Propietarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cerdoIdCerdos",
                table: "HistoriaClinicas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "recomendacionIdRecomendacion",
                table: "HistoriaClinicas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cerdoIdCerdos",
                table: "ControlSignos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veterinarios_cerdoIdCerdos",
                table: "Veterinarios",
                column: "cerdoIdCerdos");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinarios_personaIdPersona",
                table: "Veterinarios",
                column: "personaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Propietarios_cerdoIdCerdos",
                table: "Propietarios",
                column: "cerdoIdCerdos");

            migrationBuilder.CreateIndex(
                name: "IX_Propietarios_personaIdPersona",
                table: "Propietarios",
                column: "personaIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_cerdoIdCerdos",
                table: "HistoriaClinicas",
                column: "cerdoIdCerdos");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_recomendacionIdRecomendacion",
                table: "HistoriaClinicas",
                column: "recomendacionIdRecomendacion");

            migrationBuilder.CreateIndex(
                name: "IX_ControlSignos_cerdoIdCerdos",
                table: "ControlSignos",
                column: "cerdoIdCerdos");

            migrationBuilder.AddForeignKey(
                name: "FK_ControlSignos_Cerdos_cerdoIdCerdos",
                table: "ControlSignos",
                column: "cerdoIdCerdos",
                principalTable: "Cerdos",
                principalColumn: "IdCerdos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriaClinicas_Cerdos_cerdoIdCerdos",
                table: "HistoriaClinicas",
                column: "cerdoIdCerdos",
                principalTable: "Cerdos",
                principalColumn: "IdCerdos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriaClinicas_Recomendaciones_recomendacionIdRecomendacion",
                table: "HistoriaClinicas",
                column: "recomendacionIdRecomendacion",
                principalTable: "Recomendaciones",
                principalColumn: "IdRecomendacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietarios_Cerdos_cerdoIdCerdos",
                table: "Propietarios",
                column: "cerdoIdCerdos",
                principalTable: "Cerdos",
                principalColumn: "IdCerdos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietarios_Personas_personaIdPersona",
                table: "Propietarios",
                column: "personaIdPersona",
                principalTable: "Personas",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_Cerdos_cerdoIdCerdos",
                table: "Veterinarios",
                column: "cerdoIdCerdos",
                principalTable: "Cerdos",
                principalColumn: "IdCerdos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_Personas_personaIdPersona",
                table: "Veterinarios",
                column: "personaIdPersona",
                principalTable: "Personas",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControlSignos_Cerdos_cerdoIdCerdos",
                table: "ControlSignos");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoriaClinicas_Cerdos_cerdoIdCerdos",
                table: "HistoriaClinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoriaClinicas_Recomendaciones_recomendacionIdRecomendacion",
                table: "HistoriaClinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietarios_Cerdos_cerdoIdCerdos",
                table: "Propietarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietarios_Personas_personaIdPersona",
                table: "Propietarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_Cerdos_cerdoIdCerdos",
                table: "Veterinarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_Personas_personaIdPersona",
                table: "Veterinarios");

            migrationBuilder.DropIndex(
                name: "IX_Veterinarios_cerdoIdCerdos",
                table: "Veterinarios");

            migrationBuilder.DropIndex(
                name: "IX_Veterinarios_personaIdPersona",
                table: "Veterinarios");

            migrationBuilder.DropIndex(
                name: "IX_Propietarios_cerdoIdCerdos",
                table: "Propietarios");

            migrationBuilder.DropIndex(
                name: "IX_Propietarios_personaIdPersona",
                table: "Propietarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoriaClinicas_cerdoIdCerdos",
                table: "HistoriaClinicas");

            migrationBuilder.DropIndex(
                name: "IX_HistoriaClinicas_recomendacionIdRecomendacion",
                table: "HistoriaClinicas");

            migrationBuilder.DropIndex(
                name: "IX_ControlSignos_cerdoIdCerdos",
                table: "ControlSignos");

            migrationBuilder.DropColumn(
                name: "cerdoIdCerdos",
                table: "Veterinarios");

            migrationBuilder.DropColumn(
                name: "personaIdPersona",
                table: "Veterinarios");

            migrationBuilder.DropColumn(
                name: "cerdoIdCerdos",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "personaIdPersona",
                table: "Propietarios");

            migrationBuilder.DropColumn(
                name: "cerdoIdCerdos",
                table: "HistoriaClinicas");

            migrationBuilder.DropColumn(
                name: "recomendacionIdRecomendacion",
                table: "HistoriaClinicas");

            migrationBuilder.DropColumn(
                name: "cerdoIdCerdos",
                table: "ControlSignos");

            migrationBuilder.AddColumn<int>(
                name: "propietarioIdPropietario",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "veterinarioIdVeterinario",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_propietarioIdPropietario",
                table: "Personas",
                column: "propietarioIdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_veterinarioIdVeterinario",
                table: "Personas",
                column: "veterinarioIdVeterinario");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Propietarios_propietarioIdPropietario",
                table: "Personas",
                column: "propietarioIdPropietario",
                principalTable: "Propietarios",
                principalColumn: "IdPropietario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Veterinarios_veterinarioIdVeterinario",
                table: "Personas",
                column: "veterinarioIdVeterinario",
                principalTable: "Veterinarios",
                principalColumn: "IdVeterinario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
