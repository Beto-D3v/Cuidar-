using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCuidar.Migrations
{
    /// <inheritdoc />
    public partial class NovoCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "UsuarioLogins",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "Cuidadores",
                newName: "EmailAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "UsuarioLogins",
                newName: "EmailAdress");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Cuidadores",
                newName: "EmailAdress");
        }
    }
}
