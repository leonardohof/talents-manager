using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalentsManagerService.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Portfolio = table.Column<string>(nullable: true),
                    HourlySalary = table.Column<decimal>(nullable: false),
                    UpToFourHoursPerDay = table.Column<bool>(nullable: false),
                    FourToSixHoursPerDay = table.Column<bool>(nullable: false),
                    SixToHeightHoursPerDay = table.Column<bool>(nullable: false),
                    UpToEightHoursPerDay = table.Column<bool>(nullable: false),
                    OnlyWeekends = table.Column<bool>(nullable: false),
                    WorkingMorning = table.Column<bool>(nullable: false),
                    WorkingAfternoon = table.Column<bool>(nullable: false),
                    WorkingNight = table.Column<bool>(nullable: false),
                    WorkingDawn = table.Column<bool>(nullable: false),
                    WorkingBusiness = table.Column<bool>(nullable: false),
                    SkillsCollection = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Talents",
                columns: new[] { "Id", "City", "CreatedAt", "Email", "FourToSixHoursPerDay", "HourlySalary", "LastUpdatedAt", "Linkedin", "Name", "OnlyWeekends", "Phone", "Portfolio", "SixToHeightHoursPerDay", "Skype", "State", "UpToEightHoursPerDay", "UpToFourHoursPerDay", "WorkingAfternoon", "WorkingBusiness", "WorkingDawn", "WorkingMorning", "WorkingNight", "SkillsCollection" },
                values: new object[] { 1L, "Campinas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lmhofling@gmail.com", false, 85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https =//www.linkedin.com/in/leonardo-miranda-hofling-126b0320/", "Leonardo", false, "+551900000000", "xxx", false, "leonardo.hofling", "São Paulo", false, true, false, false, true, false, true, "C#;Java" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talents");
        }
    }
}
