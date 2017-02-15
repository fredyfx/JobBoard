using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobBoard.Data.Migrations
{
    public partial class JsonJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JsonJob",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationLink = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    DatePosted = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    JobID = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    LanguagesUsed = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Salary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonJob", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonJob");
        }
    }
}
