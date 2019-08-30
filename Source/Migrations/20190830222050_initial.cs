using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorTime.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TutoringRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    NumberOfPeople = table.Column<int>(nullable: false),
                    Problem = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTimeOffset>(nullable: false),
                    TutorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutoringRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TutoringRequests_Tutors_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TutoringRequests_TutorId",
                table: "TutoringRequests",
                column: "TutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TutoringRequests");

            migrationBuilder.DropTable(
                name: "Tutors");
        }
    }
}
