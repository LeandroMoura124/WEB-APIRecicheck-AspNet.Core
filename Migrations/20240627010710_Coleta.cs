using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIRecicheck.Migrations
{
    /// <inheritdoc />
    public partial class Coleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COLETA",
                columns: table => new
                {
                    coletaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    tipoResiduo = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    dataColeta = table.Column<DateTime>(type: "date", nullable: false),
                    quantidade = table.Column<string>(type: "NVARCHAR2(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COLETA", x => x.coletaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COLETA");
        }
    }
}
