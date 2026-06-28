using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entity;

namespace MyBlog.Data
{
    public class IdentityContex : IdentityDbContext<ApplicationUser>
    {
        public IdentityContex(DbContextOptions<IdentityContex> options) : base(options)
        {
        }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Web"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Mobil"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Cyber Security"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Diğer"
                }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 1,
                    Title = "ByRoot",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin/MyBlog",
                    Description = "Hizmetler, projeler, iletişim ve randevu sistemi içeren kişisel marka ve ajans web sitesi.",
                    Image = "byroot-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 1)
                },
                new Project
                {
                    ProjectId = 2,
                    Title = "CarApp",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin/MyBlog",
                    Description = "Araç listeleme, filtreleme, ilan yönetimi ve admin panel yapısına sahip otomobil projesi.",
                    Image = "carapp-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 5)
                },
                new Project
                {
                    ProjectId = 3,
                    Title = "QrMenu",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin/MyBlog",
                    Description = "Restoranlar için kategori, ürün ve görsel yönetimi bulunan dinamik QR menü uygulaması.",
                    Image = "qrmenu-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 10)
                },
                new Project
                {
                    ProjectId = 4,
                    Title = "Landing Pages",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin/MyBlog",
                    Description = "Kişisel marka, blog, portfolyo ve kurumsal tanıtım sayfaları için modern, sade ve responsive web sayfası tasarımları.",
                    Image = "landing-pages.jpg",
                    PublishedOn = new DateTime(2026, 6, 15)
                },
                new Project
                {
                    ProjectId = 5,
                    Title = "iOS SwiftUI App",
                    CategoryId = 2,
                    Link = "https://github.com/omerapaydin",
                    Description = "Swift ve SwiftUI kullanılarak geliştirilen modern, kullanıcı dostu iOS mobil uygulama arayüz çalışması.",
                    Image = "ios-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 18)
                },
                new Project
                {
                    ProjectId = 6,
                    Title = "Web Security Report",
                    CategoryId = 3,
                    Link = "https://github.com/omerapaydin",
                    Description = "Web uygulama güvenliği, zafiyet analizi, güvenli kod inceleme ve raporlama süreçlerini içeren siber güvenlik çalışması.",
                    Image = "security-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 20)
                },
                new Project
                {
                    ProjectId = 7,
                    Title = "Project Management Case",
                    CategoryId = 4,
                    Link = "https://github.com/omerapaydin",
                    Description = "Proje planlama, ihtiyaç analizi, görev takibi ve süreç yönetimi odaklı proje yönetimi çalışması.",
                    Image = "project-management.jpg",
                    PublishedOn = new DateTime(2026, 6, 22)
                }
            );
        }
    }
}