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
                columns: new[] { "Name", "Email", "Password" },
                values: new object[] { "Frits", "frits@example.com", "asd" });
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Name", "Email", "Password" },
                values: new object[] { "Horváth", "horvath@example.com", "asdasd" });


            // Add test data for Developers table
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Name", "Email" },
                values: new object[] { "Barni", "barni@example.com" });
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Name", "Email" },
                values: new object[] { "Szabi", "szabi@example.com" });
            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Name", "Email" },
                values: new object[] { "Ábel", "abel@example.com" });



            // Add test data for Project_Types table
            migrationBuilder.InsertData(
                table: "Project_Types",
                columns: new[] { "Name" },
                values: new object[] { "Backend" });

            migrationBuilder.InsertData(
                table: "Project_Types",
                columns: new[] { "Name" },
                values: new object[] { "Frontend" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove test data from Managers table
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Name",
                keyValue: "Frits");
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Name",
                keyValue: "Horváth");

            // Remove test data from Developers table
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Name",
                keyValue: "Barni");
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Name",
                keyValue: "Szabi");
            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Name",
                keyValue: "Ábel");


            // Remove test data from Project_Types table
            migrationBuilder.DeleteData(
                table: "Project_Types",
                keyColumn: "Name",
                keyValue: "Frontend");
            migrationBuilder.DeleteData(
                table: "Project_Types",
                keyColumn: "Name",
                keyValue: "Backend");
        }
    }
}
