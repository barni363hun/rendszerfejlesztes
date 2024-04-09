using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class ProjectTestData : Migration
    {

        private readonly DataContext _context;

        public ProjectTestData(DataContext context)
        {
            _context = context;
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Add example data for Projects table
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "WebAPI", GetIdByName("Backend"), "Backend solution" });
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "BlazorApp", GetIdByName("Frontend"), "Frontend solution" });
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


        // Helper method to retrieve Id by name
        private int GetIdByName(string name)
        {
            var resultId = _context.Set<Project_Type>()
                                   .FirstOrDefault(e => e.Name == name)?.Id;

            if (resultId == null)
            {
                throw new Exception($"{name} Name is not found in Project_Type.");
            }
            else
            {
                return resultId.Value;
            }
        }

    }
}
