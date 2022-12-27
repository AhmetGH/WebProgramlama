using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BitkiDunyasi.Data.Migrations
{
    /// <inheritdoc />
    public partial class ilk : Migration
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

            migrationBuilder.CreateTable(
                name: "Bitki",
                columns: table => new
                {
                    bitkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bitkiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<int>(type: "int", nullable: false),
                    UserDetailId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitki", x => x.bitkiId);
                    table.ForeignKey(
                        name: "FK_Bitki_AspNetUsers_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usercomment",
                columns: table => new
                {
                    kullaniciYorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciYorumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bitkiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usercomment", x => x.kullaniciYorumId);
                    table.ForeignKey(
                        name: "FK_Usercomment_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usercomment_Bitki_bitkiId",
                        column: x => x.bitkiId,
                        principalTable: "Bitki",
                        principalColumn: "bitkiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bitki_UserDetailId",
                table: "Bitki",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Usercomment_bitkiId",
                table: "Usercomment",
                column: "bitkiId");

            migrationBuilder.CreateIndex(
                name: "IX_Usercomment_UserDetailsId",
                table: "Usercomment",
                column: "UserDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usercomment");

            migrationBuilder.DropTable(
                name: "Bitki");

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
