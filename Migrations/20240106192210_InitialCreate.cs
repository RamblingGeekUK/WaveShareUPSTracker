using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaveShareUPS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "readings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LoadVoltage = table.Column<float>(type: "REAL", nullable: false),
                    Current = table.Column<float>(type: "REAL", nullable: false),
                    Power = table.Column<float>(type: "REAL", nullable: false),
                    PercentRemaining = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_readings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "readings");
        }
    }
}
