using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class PositionEmployeeRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    EMPLOYEE_CODE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME_THA = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LAST_NAME_THA = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FIRST_NAME_ENG = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LAST_NAME_ENG = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NICKNAME = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    GENDER = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BIRTH_DATE = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    NATIONALITY_ID = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    RACE_ID = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    RELIGION = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BLOOD_TYPE = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    PHONE_EMPLOYEE = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.EMPLOYEE_CODE);
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_POSITION_PositionId",
                        column: x => x.PositionId,
                        principalTable: "POSITION",
                        principalColumn: "POSITION_CODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_PositionId",
                table: "EMPLOYEE",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMPLOYEE");
        }
    }
}
