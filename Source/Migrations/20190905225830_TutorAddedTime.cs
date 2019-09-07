using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorTime.Migrations
{
    public partial class TutorAddedTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Tutors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Tutors");
        }
    }
}
