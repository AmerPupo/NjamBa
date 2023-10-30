using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NjamBa.Migrations
{
    public partial class UpdateOfKorisnik202310301504 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenIstice",
                table: "Korisnik",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerifikacijskiToken",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Verifikovan",
                table: "Korisnik",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "ResetTokenIstice",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "VerifikacijskiToken",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Verifikovan",
                table: "Korisnik");
        }
    }
}
