using Microsoft.EntityFrameworkCore.Migrations;

namespace _20190730EFCoreProgram.Migrations
{
    public partial class common : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EName",
                table: "ArrangeCourse",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "ArrangeCourse",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 300);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EName",
                table: "ArrangeCourse",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CName",
                table: "ArrangeCourse",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);
        }
    }
}
