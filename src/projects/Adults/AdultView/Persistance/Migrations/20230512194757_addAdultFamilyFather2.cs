using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class addAdultFamilyFather2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "how_many_children_have",
                table: "adult_father",
                newName: "how_many_child_have");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "how_many_child_have",
                table: "adult_father",
                newName: "how_many_children_have");
        }
    }
}
