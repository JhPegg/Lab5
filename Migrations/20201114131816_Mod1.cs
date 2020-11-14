using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class Mod1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "AnswerImages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "AnswerImageId",
                table: "AnswerImages",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "AnswerImages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AnswerImageId",
                table: "AnswerImages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
