using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmet_Predmets_ZkratkaPredmet",
                table: "StudentPredmet");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmet_Students_IdStudent",
                table: "StudentPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet");

            migrationBuilder.RenameTable(
                name: "StudentPredmet",
                newName: "StudentPredmets");

            migrationBuilder.RenameIndex(
                name: "IX_StudentPredmet_ZkratkaPredmet",
                table: "StudentPredmets",
                newName: "IX_StudentPredmets_ZkratkaPredmet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmets",
                table: "StudentPredmets",
                columns: new[] { "IdStudent", "ZkratkaPredmet" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmets_Predmets_ZkratkaPredmet",
                table: "StudentPredmets",
                column: "ZkratkaPredmet",
                principalTable: "Predmets",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmets_Students_IdStudent",
                table: "StudentPredmets",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmets_Predmets_ZkratkaPredmet",
                table: "StudentPredmets");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmets_Students_IdStudent",
                table: "StudentPredmets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmets",
                table: "StudentPredmets");

            migrationBuilder.RenameTable(
                name: "StudentPredmets",
                newName: "StudentPredmet");

            migrationBuilder.RenameIndex(
                name: "IX_StudentPredmets_ZkratkaPredmet",
                table: "StudentPredmet",
                newName: "IX_StudentPredmet_ZkratkaPredmet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet",
                columns: new[] { "IdStudent", "ZkratkaPredmet" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmet_Predmets_ZkratkaPredmet",
                table: "StudentPredmet",
                column: "ZkratkaPredmet",
                principalTable: "Predmets",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmet_Students_IdStudent",
                table: "StudentPredmet",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
