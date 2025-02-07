using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class _09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ManagerId",
                table: "Classes");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ManagerId",
                table: "Classes",
                column: "ManagerId",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ManagerId",
                table: "Classes");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ManagerId",
                table: "Classes",
                column: "ManagerId",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }
    }
}
