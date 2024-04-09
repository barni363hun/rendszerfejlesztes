using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InnerTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add example data for Projects table
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "WebAPI", 1, "Backend solution" });
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "BlazorApp", 2, "Frontend solution" });

            // Add example data for Tasks table
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Name", "Description", "ProjectId", "ManagerId", "Deadline" },
                values: new object[] { "Task 1", "Make backend", 1, 1, new DateTime(2024, 4, 10) });
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Name", "Description", "ProjectId", "ManagerId", "Deadline" },
                values: new object[] { "Task 2", "Make frontend", 2, 1, new DateTime(2024, 4, 10) });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            // Remove test data from Projects table
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Name",
                keyValue: "WebAPI");
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Name",
                keyValue: "BlazorApp");

            // Remove test data from Tasks table
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Name",
                keyValue: "Task 1");
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Name",
                keyValue: "Task 2");

        }
    }
}
