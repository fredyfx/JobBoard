using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobBoard.Data.Migrations
{
    public partial class WebsiteIDUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePosted",
                table: "JobID");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "JobID");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "JobID");

            migrationBuilder.CreateTable(
                name: "WebsiteID",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(nullable: true),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    Experience = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    Languages = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Salary = table.Column<float>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteID", x => x.ID);
                });

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "JobID",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "JobID",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "JobID");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "JobID");

            migrationBuilder.DropTable(
                name: "WebsiteID");

            migrationBuilder.AddColumn<string>(
                name: "DatePosted",
                table: "JobID",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "JobID",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "JobID",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
