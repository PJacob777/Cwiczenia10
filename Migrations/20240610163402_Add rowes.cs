using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cwiczenia10.Migrations
{
    /// <inheritdoc />
    public partial class Addrowes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "PK_categoru", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "PK_product", "name", "depth", "height", "width" },
                values: new object[,]
                {
                    { 1, "Product 1", 3.3m, 2.2m, 1.1m },
                    { 2, "Product 2", 1.4m, 3.4m, 2m },
                    { 3, "Product 3", 3.3m, 2.2m, 1.1m }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "PK_rol", "name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "PK_acount", "email", "first_name", "FK_role", "last_name", "phone" },
                values: new object[,]
                {
                    { 1, "john.doe@gmail.com", "John", 1, "Doe", "123456789" },
                    { 2, "alice.smith@gmail.com", "Alice", 2, "Smith", "987654321" },
                    { 3, "bob.brown@gmail.com", "Bob", 3, "Brown", "456789123" }
                });

            migrationBuilder.InsertData(
                table: "Products_Categories",
                columns: new[] { "FK_Category", "FK_product" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Shopping_Carts",
                columns: new[] { "FK_account", "FK_product", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 2, 3, 2 },
                    { 3, 2, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_Category", "FK_product" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_Category", "FK_product" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_Category", "FK_product" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_acount",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_acount",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_acount",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_categoru",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_categoru",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_categoru",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "PK_rol",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "PK_rol",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "PK_rol",
                keyValue: 3);
        }
    }
}
