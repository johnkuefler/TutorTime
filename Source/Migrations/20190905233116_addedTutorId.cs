using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorTime.Migrations
{
    public partial class addedTutorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TutoringRequests_Tutors_TutorId",
                table: "TutoringRequests");

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "TutoringRequests",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TutoringRequests_Tutors_TutorId",
                table: "TutoringRequests",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TutoringRequests_Tutors_TutorId",
                table: "TutoringRequests");

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "TutoringRequests",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_TutoringRequests_Tutors_TutorId",
                table: "TutoringRequests",
                column: "TutorId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
