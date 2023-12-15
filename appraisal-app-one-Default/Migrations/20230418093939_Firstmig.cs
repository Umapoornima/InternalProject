using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apprisal.web.App_mvc_.Migrations
{
    public partial class Firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    ApprisalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvoluvationPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfLeavesTaken = table.Column<double>(type: "float", nullable: false),
                    ClientDelivery = table.Column<int>(type: "int", nullable: false),
                    ClientDeliveryFeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibility = table.Column<int>(type: "int", nullable: false),
                    ResponsibilitiesFeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<int>(type: "int", nullable: false),
                    SkillsFeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certifiate = table.Column<int>(type: "int", nullable: false),
                    AboutCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.ApprisalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form");
        }
    }
}
