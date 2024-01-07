using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaveShareUPS.Migrations
{
    /// <inheritdoc />
    public partial class TryingDateTimeAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "readings",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "readings");
        }
    }
}
