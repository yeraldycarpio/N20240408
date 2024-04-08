using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N20240408.AccesoADatos.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonaN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreN = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoN = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusN = table.Column<byte>(type: "tinyint", nullable: false),
                    ComentarioN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaN", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonaN");
        }
    }
}
