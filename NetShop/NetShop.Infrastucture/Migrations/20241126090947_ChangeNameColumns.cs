using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetShop.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Products",
                newName: "UpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "NameProduct");

            migrationBuilder.RenameColumn(
                name: "Description2",
                table: "Products",
                newName: "DescriptionProduct2");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "DescriptionProduct");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "IdCategory");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Categories",
                newName: "UpdatedTime");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "NameCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedTime",
                table: "Products",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "NameProduct",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "DescriptionProduct2",
                table: "Products",
                newName: "Description2");

            migrationBuilder.RenameColumn(
                name: "DescriptionProduct",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "UpdatedTime",
                table: "Categories",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "NameCategory",
                table: "Categories",
                newName: "Name");
        }
    }
}
