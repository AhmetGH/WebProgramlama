using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlama.Data.Migrations
{
    /// <inheritdoc />
    public partial class adddname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tecrube",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yas",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tecrube",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Yas",
                table: "AspNetUsers");
        }
    }
}
