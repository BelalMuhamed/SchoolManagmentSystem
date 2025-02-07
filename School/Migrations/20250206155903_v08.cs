using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class v08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classes_ManagerId",
                table: "Classes");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ManagerId",
                table: "Classes",
                column: "ManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classes_ManagerId",
                table: "Classes");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ManagerId",
                table: "Classes",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");
        }
    }
}
