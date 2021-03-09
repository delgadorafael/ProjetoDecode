using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDecode.Infrastructure.Data.Migrations
{
    public partial class PeopleHobbiesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_People_PersonId",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_PersonId",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Hobbies");

            migrationBuilder.CreateTable(
                name: "PeopleHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    HobbiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeopleHobbies_Hobbies_HobbiesId",
                        column: x => x.HobbiesId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeopleHobbies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleHobbies_HobbiesId",
                table: "PeopleHobbies",
                column: "HobbiesId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleHobbies_PersonId",
                table: "PeopleHobbies",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleHobbies");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Hobbies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_PersonId",
                table: "Hobbies",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_People_PersonId",
                table: "Hobbies",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
