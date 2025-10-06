using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdRelationShipBetweenInstructorAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiringDate = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "dbo",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiringDate = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                    table.ForeignKey(
                        name: "FK_Instructors_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptID",
                schema: "dbo",
                table: "Students",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                table: "Department",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptId",
                schema: "dbo",
                table: "Instructors",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DeptID",
                schema: "dbo",
                table: "Students",
                column: "DeptID",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructors_ManagerId",
                table: "Department",
                column: "ManagerId",
                principalSchema: "dbo",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DeptID",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructors_ManagerId",
                table: "Department");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptID",
                schema: "dbo",
                table: "Students");
        }
    }
}
