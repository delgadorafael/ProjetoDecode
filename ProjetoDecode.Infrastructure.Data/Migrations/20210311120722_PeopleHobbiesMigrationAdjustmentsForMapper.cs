﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDecode.Infrastructure.Data.Migrations
{
    public partial class PeopleHobbiesMigrationAdjustmentsForMapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleHobbies_People_PersonId",
                table: "PeopleHobbies");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PeopleHobbies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleHobbies_People_PersonId",
                table: "PeopleHobbies",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleHobbies_People_PersonId",
                table: "PeopleHobbies");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "PeopleHobbies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleHobbies_People_PersonId",
                table: "PeopleHobbies",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
