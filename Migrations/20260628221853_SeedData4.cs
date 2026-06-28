using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlog.Migrations
{
    /// <inheritdoc />
    public partial class SeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "Image", "Link" },
                values: new object[] { "byroot1.jpg", "https://github.com/omerapaydin" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Link", "Title" },
                values: new object[] { "Saat ürünleri için kategori, ürün listeleme, detay sayfası, sepet, sipariş oluşturma ve admin panel yönetimi bulunan e-ticaret web uygulaması.", "saat1.jpg", "https://github.com/omerapaydin", "E-Saat" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Link", "Title" },
                values: new object[] { "Etik hackerlık, ağ güvenliği, bilgi toplama, zafiyet analizi, XSS, SQL enjeksiyonu, web pentesting, parola hash kırma ve sosyal mühendislik konularını içeren siber güvenlik eğitim notları ve uygulamalı çalışmalar.", "cyber1.jpg", "https://github.com/omerapaydin/SiberGuvenlik", "Siber Güvenlik" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Takı ürünleri için kategori filtreleme, ürün listeleme, detay sayfası, sepet, sipariş oluşturma ve admin panel yönetimi bulunan dinamik e-ticaret web uygulaması.", "tak2.jpg", "E-Takı" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Psikologlar için danışan randevu oluşturma, müsait saat seçimi, iletişim formu ve admin panel üzerinden randevu yönetimi özellikleri bulunan modern web uygulaması.", "psiko1.jpg", "Psikolog App" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Restoran ve kafeler için kategori, ürün, fiyat ve görsel yönetimi bulunan; müşterilerin QR kod üzerinden menüye kolayca ulaşmasını sağlayan dinamik web uygulaması.", "qr.jpg", "QrMenü" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                column: "Image",
                value: "agile1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "Image", "Link" },
                values: new object[] { "byroot-project.jpg", "https://github.com/omerapaydin/MyBlog" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Link", "Title" },
                values: new object[] { "Araç listeleme, filtreleme, ilan yönetimi ve admin panel yapısına sahip otomobil projesi.", "carapp-project.jpg", "https://github.com/omerapaydin/MyBlog", "CarApp" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Link", "Title" },
                values: new object[] { "Restoranlar için kategori, ürün ve görsel yönetimi bulunan dinamik QR menü uygulaması.", "qrmenu-project.jpg", "https://github.com/omerapaydin/MyBlog", "QrMenu" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Kişisel marka, blog, portfolyo ve kurumsal tanıtım sayfaları için modern, sade ve responsive web sayfası tasarımları.", "landing-pages.jpg", "Landing Pages" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Swift ve SwiftUI kullanılarak geliştirilen modern, kullanıcı dostu iOS mobil uygulama arayüz çalışması.", "ios-project.jpg", "iOS SwiftUI App" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Web uygulama güvenliği, zafiyet analizi, güvenli kod inceleme ve raporlama süreçlerini içeren siber güvenlik çalışması.", "security-project.jpg", "Web Security Report" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 7,
                column: "Image",
                value: "project-management.jpg");
        }
    }
}
