using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCuidar.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao_BD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaAtuacao",
                table: "Cuidadores");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "UsuarioLogins",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UsuarioLogins",
                newName: "EmailAdress");

            migrationBuilder.RenameColumn(
                name: "ValorHora",
                table: "Cuidadores",
                newName: "NightValue");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Cuidadores",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Cuidadores",
                newName: "ProfessionalNumber");

            migrationBuilder.RenameColumn(
                name: "NumeroProfissional",
                table: "Cuidadores",
                newName: "Profession");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cuidadores",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Cuidadores",
                newName: "Presentation");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cuidadores",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Cuidadores",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Cuidadores",
                newName: "EmailAdress");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Cuidadores",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Cuidadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DayValue",
                table: "Cuidadores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Cuidadores");

            migrationBuilder.DropColumn(
                name: "DayValue",
                table: "Cuidadores");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UsuarioLogins",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "UsuarioLogins",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Cuidadores",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "ProfessionalNumber",
                table: "Cuidadores",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Cuidadores",
                newName: "NumeroProfissional");

            migrationBuilder.RenameColumn(
                name: "Presentation",
                table: "Cuidadores",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Cuidadores",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Cuidadores",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "NightValue",
                table: "Cuidadores",
                newName: "ValorHora");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cuidadores",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "Cuidadores",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Cuidadores",
                newName: "DataNascimento");

            migrationBuilder.AddColumn<string>(
                name: "AreaAtuacao",
                table: "Cuidadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
