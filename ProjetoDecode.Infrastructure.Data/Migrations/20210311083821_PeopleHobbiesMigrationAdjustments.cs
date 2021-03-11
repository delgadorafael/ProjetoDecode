using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDecode.Infrastructure.Data.Migrations
{
    public partial class PeopleHobbiesMigrationAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbiesId",
                table: "PeopleHobbies");

            migrationBuilder.RenameColumn(
                name: "HobbiesId",
                table: "PeopleHobbies",
                newName: "HobbyId");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleHobbies_HobbiesId",
                table: "PeopleHobbies",
                newName: "IX_PeopleHobbies_HobbyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbyId",
                table: "PeopleHobbies",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbyId",
                table: "PeopleHobbies");

            migrationBuilder.RenameColumn(
                name: "HobbyId",
                table: "PeopleHobbies",
                newName: "HobbiesId");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleHobbies_HobbyId",
                table: "PeopleHobbies",
                newName: "IX_PeopleHobbies_HobbiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbiesId",
                table: "PeopleHobbies",
                column: "HobbiesId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
