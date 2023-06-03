using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tryitter_back_end.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoNomesDosCampos2EIncluindoDataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Criado_em",
                table: "Users",
                newName: "Ultima_atualizacao");

            migrationBuilder.RenameColumn(
                name: "Atualizado_em",
                table: "Users",
                newName: "Data_criacao");

            migrationBuilder.RenameColumn(
                name: "Criado_em",
                table: "Posts",
                newName: "Ultima_atualizacao");

            migrationBuilder.RenameColumn(
                name: "Atualizado_em",
                table: "Posts",
                newName: "Data_criacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ultima_atualizacao",
                table: "Users",
                newName: "Criado_em");

            migrationBuilder.RenameColumn(
                name: "Data_criacao",
                table: "Users",
                newName: "Atualizado_em");

            migrationBuilder.RenameColumn(
                name: "Ultima_atualizacao",
                table: "Posts",
                newName: "Criado_em");

            migrationBuilder.RenameColumn(
                name: "Data_criacao",
                table: "Posts",
                newName: "Atualizado_em");
        }
    }
}
