using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Xml.Linq;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class TaskTestData : Migration
    {
        private readonly DataContext _context;

        public TaskTestData(DataContext context)
        {
            _context = context;
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
