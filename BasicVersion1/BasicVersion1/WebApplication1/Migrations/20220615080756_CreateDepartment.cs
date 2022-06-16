using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class CreateDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EMPLOYEE",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DEPARTMENT",
                columns: table => new
                {
                    DEPARTMENT_CODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPARTMENT_NAME_THA = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DEPARTMENT_NAME_ENG = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEPARTMENT", x => x.DEPARTMENT_CODE);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_DepartmentId",
                table: "EMPLOYEE",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EMPLOYEE_DEPARTMENT_DepartmentId",
                table: "EMPLOYEE",
                column: "DepartmentId",
                principalTable: "DEPARTMENT",
                principalColumn: "DEPARTMENT_CODE",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EMPLOYEE_DEPARTMENT_DepartmentId",
                table: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "DEPARTMENT");

            migrationBuilder.DropIndex(
                name: "IX_EMPLOYEE_DepartmentId",
                table: "EMPLOYEE");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EMPLOYEE");
        }
    }
}
