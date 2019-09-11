using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorTime.Migrations
{
    public partial class AddedImageUrlToTutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Tutors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Tutors");
        }
    }
}
