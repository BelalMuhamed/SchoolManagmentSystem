using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class v010 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrolllmentTeacherClassSubject",
                table: "EnrolllmentTeacherClassSubject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrolllmentTeacherClassSubject",
                table: "EnrolllmentTeacherClassSubject",
                columns: new[] { "date", "Lesson", "classId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EnrolllmentTeacherClassSubject",
                table: "EnrolllmentTeacherClassSubject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnrolllmentTeacherClassSubject",
                table: "EnrolllmentTeacherClassSubject",
                columns: new[] { "date", "Lesson" });
        }
    }
}
