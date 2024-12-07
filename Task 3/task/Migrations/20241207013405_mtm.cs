using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task.Migrations
{
    /// <inheritdoc />
    public partial class mtm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_grade_studentId",
                table: "enrollment");

            migrationBuilder.DropIndex(
                name: "IX_enrollment_studentId",
                table: "enrollment");

            migrationBuilder.AddColumn<int>(
                name: "courceId",
                table: "enrollment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gradeId",
                table: "enrollment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_enrollment_courceId",
                table: "enrollment",
                column: "courceId");

            migrationBuilder.CreateIndex(
                name: "IX_enrollment_gradeId",
                table: "enrollment",
                column: "gradeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_enrollment_studentId",
                table: "enrollment",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_Cource_courceId",
                table: "enrollment",
                column: "courceId",
                principalTable: "Cource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_Students_studentId",
                table: "enrollment",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_grade_gradeId",
                table: "enrollment",
                column: "gradeId",
                principalTable: "grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_Cource_courceId",
                table: "enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_Students_studentId",
                table: "enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_enrollment_grade_gradeId",
                table: "enrollment");

            migrationBuilder.DropIndex(
                name: "IX_enrollment_courceId",
                table: "enrollment");

            migrationBuilder.DropIndex(
                name: "IX_enrollment_gradeId",
                table: "enrollment");

            migrationBuilder.DropIndex(
                name: "IX_enrollment_studentId",
                table: "enrollment");

            migrationBuilder.DropColumn(
                name: "courceId",
                table: "enrollment");

            migrationBuilder.DropColumn(
                name: "gradeId",
                table: "enrollment");

            migrationBuilder.CreateIndex(
                name: "IX_enrollment_studentId",
                table: "enrollment",
                column: "studentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_enrollment_grade_studentId",
                table: "enrollment",
                column: "studentId",
                principalTable: "grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
