using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Add test data for Projects table
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "WebAPI", 2, ".net rest api" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Name", "TypeId", "Description" },
                values: new object[] { "BlazorApp", 1, "blazor frontend mert c#" });

            // Add test data for Tasks table
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Name", "Description", "Deadline" },
                values: new object[] { "Redmine", "Meg kell csinálni :(", DateTime.UtcNow.AddDays(2) });

            // Connect developers to projects
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 2; j++)
            //    {
            //        migrationBuilder.InsertData(
            //            table: "DeveloperProject",
            //            columns: new[] { "DevelopersId", "ProjectId", "" },
            //            values: new object[] { i, j, });
            //    }
            //}

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

            // Remove test data from Tasks table
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Name",
                keyValue: "Redmine");


            // Disconnect developers from projects
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 2; j++)
            //    {
            //        migrationBuilder.DeleteData(
            //            table: "DeveloperProject",
            //            keyColumns: new[] { "DevelopersId", "ProjectId" },
            //            keyValues: new object[] { i, j });
            //    }
            //}
        }
    }
}
