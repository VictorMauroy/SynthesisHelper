using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SynthesisAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterCombination",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterCombination", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonsterItems",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    gameid = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    family = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    rank = table.Column<char>(type: "character(1)", nullable: false),
                    details = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    statistics = table.Column<int[]>(type: "integer[]", nullable: false),
                    reservation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isactive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterItems", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterMonsterCombination");

            migrationBuilder.DropTable(
                name: "MonsterCombination");

            migrationBuilder.DropTable(
                name: "MonsterItems");
        }
    }
}
