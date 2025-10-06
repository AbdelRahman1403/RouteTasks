using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondRelationShipBetweenStudentAndCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stu_Crs_Stu_ID",
                table: "Stu_Crs",
                column: "Stu_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stu_Crs_Courses_Crs_ID",
                table: "Stu_Crs",
                column: "Crs_ID",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "Crs_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stu_Crs_Students_Stu_ID",
                table: "Stu_Crs",
                column: "Stu_ID",
                principalSchema: "dbo",
                principalTable: "Students",
                principalColumn: "StuID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stu_Crs_Courses_Crs_ID",
                table: "Stu_Crs");

            migrationBuilder.DropForeignKey(
                name: "FK_Stu_Crs_Students_Stu_ID",
                table: "Stu_Crs");

            migrationBuilder.DropIndex(
                name: "IX_Stu_Crs_Stu_ID",
                table: "Stu_Crs");
        }
    }
}
