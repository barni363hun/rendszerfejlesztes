
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


        }
    }
}





using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DevProjTestConnections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Connect developers to projects
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    migrationBuilder.InsertData(
                        table: "DeveloperProject",
                        columns: new[] { "DevelopersId", "ProjectsId" },
                        values: new object[] { i, j, });
                }
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            // Disconnect developers from projects
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    migrationBuilder.DeleteData(
                        table: "DeveloperProject",
                        keyColumns: new[] { "DevelopersId", "ProjectsId" },
                        keyValues: new object[] { i, j });
                }
            }
        }
    }
}
