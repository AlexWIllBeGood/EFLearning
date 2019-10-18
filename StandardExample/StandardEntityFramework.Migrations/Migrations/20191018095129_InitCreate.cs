using Microsoft.EntityFrameworkCore.Migrations;

namespace StandardEntityFramework.Migrations.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherTest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArrangeCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TeacherId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrangeCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArrangeCourses_StudentTest_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArrangeCourses_TeacherTest_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "TeacherTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StudentTest",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "s1" },
                    { 2, "s2" },
                    { 3, "s3" },
                    { 4, "s4" },
                    { 5, "s5" }
                });

            migrationBuilder.InsertData(
                table: "TeacherTest",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "t1" },
                    { 2, "t2" },
                    { 3, "t3" },
                    { 4, "t4" },
                    { 5, "t5" }
                });

            migrationBuilder.InsertData(
                table: "ArrangeCourses",
                columns: new[] { "Id", "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 2 },
                    { 5, 5, 2 },
                    { 6, 5, 2 },
                    { 7, 2, 3 },
                    { 8, 4, 3 },
                    { 9, 5, 3 },
                    { 10, 3, 4 },
                    { 11, 4, 4 },
                    { 12, 5, 4 },
                    { 13, 1, 4 },
                    { 14, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArrangeCourses_StudentId",
                table: "ArrangeCourses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ArrangeCourses_TeacherId",
                table: "ArrangeCourses",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArrangeCourses");

            migrationBuilder.DropTable(
                name: "StudentTest");

            migrationBuilder.DropTable(
                name: "TeacherTest");
        }
    }
}
