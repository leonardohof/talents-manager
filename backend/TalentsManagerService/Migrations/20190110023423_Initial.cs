using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalentsManagerService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knowledges",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledges", x => x.Id);
                });

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
                    AvailabilityHour = table.Column<int>(nullable: false),
                    AvailabilityPartOfDay = table.Column<int>(nullable: false),
                    HourlySalary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalentKnowledges",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    KnowledgeId = table.Column<long>(nullable: false),
                    SkillLevel = table.Column<int>(nullable: false),
                    TalentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentKnowledges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentKnowledges_Knowledges_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalTable: "Knowledges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalentKnowledges_Talents_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2019, 1, 10, 0, 34, 23, 239, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "Ionic" },
                    { 2L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "Android" },
                    { 3L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "iOS" },
                    { 4L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "HTML" },
                    { 5L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "CSS" },
                    { 6L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "Bootstrap" },
                    { 7L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "jQuery" },
                    { 8L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "AngularJs" },
                    { 9L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "Java" },
                    { 10L, new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), new DateTime(2019, 1, 10, 0, 34, 23, 243, DateTimeKind.Local), "ASP .NET MVC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TalentKnowledges_KnowledgeId",
                table: "TalentKnowledges",
                column: "KnowledgeId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentKnowledges_TalentId",
                table: "TalentKnowledges",
                column: "TalentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TalentKnowledges");

            migrationBuilder.DropTable(
                name: "Knowledges");

            migrationBuilder.DropTable(
                name: "Talents");
        }
    }
}
