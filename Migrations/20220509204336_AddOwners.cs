using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_core_learning.Migrations
{
    public partial class AddOwners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetUser",
                columns: table => new
                {
                    OwnersId = table.Column<Guid>(type: "uuid", nullable: false),
                    PetsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetUser", x => new { x.OwnersId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_PetUser_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetUser_Users_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetUser_PetsId",
                table: "PetUser",
                column: "PetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetUser");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
