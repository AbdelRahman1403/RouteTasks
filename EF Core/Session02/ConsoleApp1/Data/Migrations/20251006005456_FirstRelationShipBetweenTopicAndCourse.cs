using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstRelationShipBetweenTopicAndCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "dbo",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Crs_Duration = table.Column<int>(type: "int", nullable: false),
                    Crs_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_Id);
                });

            migrationBuilder.CreateTable(
                name: "Stu_Crs",
                columns: table => new
                {
                    Stu_ID = table.Column<int>(type: "int", nullable: false),
                    Crs_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stu_Crs", x => new { x.Crs_ID, x.Stu_ID });
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "dbo",
                columns: table => new
                {
                    StuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DeptID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StuID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                schema: "dbo",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK_Topics_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalSchema: "dbo",
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Crs_Id",
                schema: "dbo",
                table: "Topics",
                column: "Crs_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stu_Crs");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Topics",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "dbo");
        }
    }
}
