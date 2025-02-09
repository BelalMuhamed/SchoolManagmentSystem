using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class v011 : Migration
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
                columns: new[] { "date", "Lesson", "classId", "TeacherId" });
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
                columns: new[] { "date", "Lesson", "classId" });
        }
    }
}
