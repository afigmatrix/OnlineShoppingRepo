using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopping.Migrations
{
    /// <inheritdoc />
    public partial class changeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstSectionSlide",
                table: "FirstSectionSlide");

            migrationBuilder.RenameTable(
                name: "FirstSectionSlide",
                newName: "FirstSectionSlides");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstSectionSlides",
                table: "FirstSectionSlides",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstSectionSlides",
                table: "FirstSectionSlides");

            migrationBuilder.RenameTable(
                name: "FirstSectionSlides",
                newName: "FirstSectionSlide");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstSectionSlide",
                table: "FirstSectionSlide",
                column: "Id");
        }
    }
}
