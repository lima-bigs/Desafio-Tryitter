using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tryitter_back_end.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoNomesDosCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Users",
                newName: "Criado_em");

            migrationBuilder.RenameColumn(
                name: "AtualizadoEm",
                table: "Users",
                newName: "Atualizado_em");

            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "Posts",
                newName: "Criado_em");

            migrationBuilder.RenameColumn(
                name: "AtualizadoEm",
                table: "Posts",
                newName: "Atualizado_em");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Criado_em",
                table: "Users",
                newName: "CriadoEm");

            migrationBuilder.RenameColumn(
                name: "Atualizado_em",
                table: "Users",
                newName: "AtualizadoEm");

            migrationBuilder.RenameColumn(
                name: "Criado_em",
                table: "Posts",
                newName: "CriadoEm");

            migrationBuilder.RenameColumn(
                name: "Atualizado_em",
                table: "Posts",
                newName: "AtualizadoEm");
        }
    }
}
