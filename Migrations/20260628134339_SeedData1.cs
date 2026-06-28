using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBlog.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Projects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectId");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Image", "PublishedOn", "Title" },
                values: new object[,]
                {
                    { 1, "Hizmetler, projeler, iletişim ve randevu sistemi içeren kişisel marka ve ajans web sitesi.", "byroot-project.jpg", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ByRoot" },
                    { 2, "Araç listeleme, filtreleme, ilan yönetimi ve admin panel yapısına sahip otomobil projesi.", "carapp-project.jpg", new DateTime(2026, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "CarApp" },
                    { 3, "Restoranlar için kategori, ürün ve görsel yönetimi bulunan dinamik QR menü uygulaması.", "qrmenu-project.jpg", new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "QrMenu" },
                    { 4, "Kişisel marka, blog, portfolyo ve kurumsal tanıtım sayfaları için modern, sade ve responsive web sayfası tasarımları.", "landing-pages.jpg", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Landing Pages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Comments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "ProjectId");
        }
    }
}
