using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetShop.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnUrlImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImg",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImg",
                table: "Products");
        }
    }
}
