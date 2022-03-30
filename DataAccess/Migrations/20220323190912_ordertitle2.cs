using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class ordertitle2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderTitle",
                table: "Orders",
                newName: "OrderTitle2");

            migrationBuilder.AddColumn<string>(
                name: "OrderTitle1",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTitle1",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderTitle2",
                table: "Orders",
                newName: "OrderTitle");
        }
    }
}
