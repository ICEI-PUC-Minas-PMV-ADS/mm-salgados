using Microsoft.EntityFrameworkCore.Migrations;

namespace MMSalgados.Infra.Data.Migrations
{
    public partial class AddRoleCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PerfilUsuario",
                columns: new[] { "Id", "Nome", "Situacao" },
                values: new object[] { 2, "CLIENTE", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PerfilUsuario",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
