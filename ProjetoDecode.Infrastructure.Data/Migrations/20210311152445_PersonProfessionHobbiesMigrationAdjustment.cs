using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDecode.Infrastructure.Data.Migrations
{
    public partial class PersonProfessionHobbiesMigrationAdjustment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Professions_ProfessionId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbyId",
                table: "PeopleHobbies");

            migrationBuilder.DropIndex(
                name: "IX_PeopleHobbies_HobbyId",
                table: "PeopleHobbies");

            migrationBuilder.DropIndex(
                name: "IX_People_ProfessionId",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "HobbyId",
                table: "PeopleHobbies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HobbyId",
                table: "PeopleHobbies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionId",
                table: "People",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleHobbies_HobbyId",
                table: "PeopleHobbies",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_People_ProfessionId",
                table: "People",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Professions_ProfessionId",
                table: "People",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleHobbies_Hobbies_HobbyId",
                table: "PeopleHobbies",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
