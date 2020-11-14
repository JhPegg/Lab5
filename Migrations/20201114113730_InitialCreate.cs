using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerImages",
                columns: table => new
                {
                    AnswerImageId = table.Column<string>(nullable: false),
                    FileName = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerImages", x => x.AnswerImageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerImages");
        }
    }
}
