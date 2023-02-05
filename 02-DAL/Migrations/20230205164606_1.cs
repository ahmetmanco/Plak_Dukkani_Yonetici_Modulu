using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_DAL.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlbümBilgileri",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbümAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanatçıveyaGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ÇıkışTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    İndirimOranı = table.Column<double>(type: "float", nullable: false),
                    SatisiVarMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbümBilgileri", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Yönetici",
                columns: table => new
                {
                    YöneticiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YöneticiAdı = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    YoneticiSoyadi = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yönetici", x => x.YöneticiId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yönetici_EMail",
                table: "Yönetici",
                column: "EMail",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbümBilgileri");

            migrationBuilder.DropTable(
                name: "Yönetici");
        }
    }
}
