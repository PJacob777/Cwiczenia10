using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia10.Migrations
{
    /// <inheritdoc />
    public partial class CorrectForeighnkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_roleIdRole",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_roleIdRole",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "roleIdRole",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FK_role",
                table: "Accounts",
                column: "FK_role");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_FK_role",
                table: "Accounts",
                column: "FK_role",
                principalTable: "Roles",
                principalColumn: "PK_rol",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_FK_role",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_FK_role",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "roleIdRole",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_roleIdRole",
                table: "Accounts",
                column: "roleIdRole");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_roleIdRole",
                table: "Accounts",
                column: "roleIdRole",
                principalTable: "Roles",
                principalColumn: "PK_rol",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
