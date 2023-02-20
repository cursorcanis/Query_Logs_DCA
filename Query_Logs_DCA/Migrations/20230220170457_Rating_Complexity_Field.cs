using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Query_Logs_DCA.Migrations
{
    public partial class Rating_Complexity_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating_Complexity",
                table: "Query",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating_Complexity",
                table: "Query");
        }
    }
}
