using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class OuterTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add test data for Managers table
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "name", "email", "password" },
                values: new object[] { "Frits", "frits@example.com", "asd" });
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "name", "email", "password" },
                values: new object[] { "Horváth", "horvath@example.com", "asdasd" });


            // Add test data for Developers table
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "name", "email" },
                values: new object[] { "Barni", "barni@example.com" });
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "name", "email" },
                values: new object[] { "Szabi", "szabi@example.com" });
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "name", "email" },
                values: new object[] { "Ábel", "abel@example.com" });



            // Add test data for Project_Types table
            migrationBuilder.InsertData(
                table: "ProjectTypes",
                columns: new[] { "name" },
                values: new object[] { "Backend" });

            migrationBuilder.InsertData(
                table: "ProjectTypes",
                columns: new[] { "name" },
                values: new object[] { "Frontend" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove test data from Managers table
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "name",
                keyValue: "Frits");
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "name",
                keyValue: "Horváth");

            // Remove test data from Developers table
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "name",
                keyValue: "Barni");
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "name",
                keyValue: "Szabi");
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "name",
                keyValue: "Ábel");


            // Remove test data from Project_Types table
            migrationBuilder.DeleteData(
                table: "ProjectTypes",
                keyColumn: "name",
                keyValue: "Frontend");
            migrationBuilder.DeleteData(
                table: "ProjectTypes",
                keyColumn: "name",
                keyValue: "Backend");
        }
    }
}
