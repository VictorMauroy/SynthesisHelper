using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SynthesisAPI.Migrations
{
    /// <inheritdoc />
    public partial class ShortenedNameAndPropertyFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterMonsterCombination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterCombination",
                table: "MonsterCombination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterItems",
                table: "MonsterItems");

            migrationBuilder.RenameTable(
                name: "MonsterItems",
                newName: "Monsters");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MonsterCombination",
                newName: "CombinationId");

            migrationBuilder.RenameColumn(
                name: "reservation_date",
                table: "Monsters",
                newName: "creation_date");

            migrationBuilder.RenameColumn(
                name: "isactive",
                table: "Monsters",
                newName: "is_active");

            migrationBuilder.AddColumn<Guid>(
                name: "MonsterId",
                table: "MonsterCombination",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterCombination",
                table: "MonsterCombination",
                columns: new[] { "CombinationId", "MonsterId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Combinations",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combinations", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterCombination_MonsterId",
                table: "MonsterCombination",
                column: "MonsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterCombination_Combinations_CombinationId",
                table: "MonsterCombination",
                column: "CombinationId",
                principalTable: "Combinations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterCombination_Monsters_MonsterId",
                table: "MonsterCombination",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonsterCombination_Combinations_CombinationId",
                table: "MonsterCombination");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterCombination_Monsters_MonsterId",
                table: "MonsterCombination");

            migrationBuilder.DropTable(
                name: "Combinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonsterCombination",
                table: "MonsterCombination");

            migrationBuilder.DropIndex(
                name: "IX_MonsterCombination_MonsterId",
                table: "MonsterCombination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "MonsterId",
                table: "MonsterCombination");

            migrationBuilder.RenameTable(
                name: "Monsters",
                newName: "MonsterItems");

            migrationBuilder.RenameColumn(
                name: "CombinationId",
                table: "MonsterCombination",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "MonsterItems",
                newName: "isactive");

            migrationBuilder.RenameColumn(
                name: "creation_date",
                table: "MonsterItems",
                newName: "reservation_date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterCombination",
                table: "MonsterCombination",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonsterItems",
                table: "MonsterItems",
                column: "id");

            migrationBuilder.CreateTable(
                name: "MonsterMonsterCombination",
                columns: table => new
                {
                    CombinationId = table.Column<Guid>(type: "uuid", nullable: false),
                    MonsterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterMonsterCombination", x => new { x.CombinationId, x.MonsterId });
                    table.ForeignKey(
                        name: "FK_MonsterMonsterCombination_MonsterCombination_CombinationId",
                        column: x => x.CombinationId,
                        principalTable: "MonsterCombination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterMonsterCombination_MonsterItems_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "MonsterItems",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterMonsterCombination_MonsterId",
                table: "MonsterMonsterCombination",
                column: "MonsterId");
        }
    }
}
