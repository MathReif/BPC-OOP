using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    Zkratka = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.Zkratka);
                });

            migrationBuilder.CreateTable(
                name: "Hodnocenis",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Datumt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Znamka = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodnocenis", x => new { x.IdStudent, x.ZkratkaPredmet });
                    table.ForeignKey(
                        name: "FK_Hodnocenis_Predmets_ZkratkaPredmet",
                        column: x => x.ZkratkaPredmet,
                        principalTable: "Predmets",
                        principalColumn: "Zkratka",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hodnocenis_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentPredmet",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPredmet", x => new { x.IdStudent, x.ZkratkaPredmet });
                    table.ForeignKey(
                        name: "FK_StudentPredmet_Predmets_ZkratkaPredmet",
                        column: x => x.ZkratkaPredmet,
                        principalTable: "Predmets",
                        principalColumn: "Zkratka",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPredmet_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hodnocenis_ZkratkaPredmet",
                table: "Hodnocenis",
                column: "ZkratkaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPredmet_ZkratkaPredmet",
                table: "StudentPredmet",
                column: "ZkratkaPredmet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodnocenis");

            migrationBuilder.DropTable(
                name: "StudentPredmet");

            migrationBuilder.DropTable(
                name: "Predmets");
        }
    }
}
