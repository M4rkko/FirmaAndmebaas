using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaAndmebaas.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Lapsed",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_EmployeeID",
                table: "Lapsed",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Lapsed_Employee_EmployeeID",
                table: "Lapsed",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lapsed_Employee_EmployeeID",
                table: "Lapsed");

            migrationBuilder.DropIndex(
                name: "IX_Lapsed_EmployeeID",
                table: "Lapsed");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Lapsed");
        }
    }
}
