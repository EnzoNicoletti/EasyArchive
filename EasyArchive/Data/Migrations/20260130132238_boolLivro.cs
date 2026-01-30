using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyArchive.Data.Migrations
{
    /// <inheritdoc />
    public partial class boolLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Emprestado",
                table: "Livros",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emprestado",
                table: "Livros");
        }
    }
}
