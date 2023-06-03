using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tryitter_back_end.Migrations
{
    /// <inheritdoc />
    public partial class RemovidosOsCamposDeCriacaoEAtualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data_criacao",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ultima_atualizacao",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Data_criacao",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Ultima_atualizacao",
                table: "Posts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data_criacao",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ultima_atualizacao",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_criacao",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ultima_atualizacao",
                table: "Posts",
                type: "datetime2",
                nullable: true);
        }
    }
}
