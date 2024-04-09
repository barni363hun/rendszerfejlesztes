using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class ProjectTestData : Migration
    {
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
        }

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

        }

    }
}
