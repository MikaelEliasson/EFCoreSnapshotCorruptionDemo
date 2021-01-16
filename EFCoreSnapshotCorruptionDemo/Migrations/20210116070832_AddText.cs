using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSnapshotCorruptionDemo.Migrations
{
    public partial class AddText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Blogposts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Blogposts");
        }
    }
}
