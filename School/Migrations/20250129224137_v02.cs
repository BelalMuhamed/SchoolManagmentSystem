using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachersAttendance_TeachersAttendance_TeacherAttendanceday_TeacherAttendanceTeacherId",
                table: "TeachersAttendance");

            migrationBuilder.DropIndex(
                name: "IX_TeachersAttendance_TeacherAttendanceday_TeacherAttendanceTeacherId",
                table: "TeachersAttendance");

            migrationBuilder.DropColumn(
                name: "TeacherAttendanceTeacherId",
                table: "TeachersAttendance");

            migrationBuilder.DropColumn(
                name: "TeacherAttendanceday",
                table: "TeachersAttendance");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherAttendanceTeacherId",
                table: "TeachersAttendance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TeacherAttendanceday",
                table: "TeachersAttendance",
                type: "date",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeachersAttendance_TeacherAttendanceday_TeacherAttendanceTeacherId",
                table: "TeachersAttendance",
                columns: new[] { "TeacherAttendanceday", "TeacherAttendanceTeacherId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersAttendance_TeachersAttendance_TeacherAttendanceday_TeacherAttendanceTeacherId",
                table: "TeachersAttendance",
                columns: new[] { "TeacherAttendanceday", "TeacherAttendanceTeacherId" },
                principalTable: "TeachersAttendance",
                principalColumns: new[] { "day", "TeacherId" });
        }
    }
}
