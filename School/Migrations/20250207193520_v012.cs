using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class v012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_Subjects_SubId",
                table: "Degrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_students_StudentId",
                table: "Degrees");

            migrationBuilder.AlterColumn<int>(
                name: "SubId",
                table: "Degrees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Degrees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Degrees_Subjects_SubId",
                table: "Degrees",
                column: "SubId",
                principalTable: "Subjects",
                principalColumn: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Degrees_students_StudentId",
                table: "Degrees",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_Subjects_SubId",
                table: "Degrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Degrees_students_StudentId",
                table: "Degrees");

            migrationBuilder.AlterColumn<int>(
                name: "SubId",
                table: "Degrees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Degrees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Degrees_Subjects_SubId",
                table: "Degrees",
                column: "SubId",
                principalTable: "Subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Degrees_students_StudentId",
                table: "Degrees",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
