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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 1,
                    Title = "ByRoot",
                    Description = "Hizmetler, projeler, iletişim ve randevu sistemi içeren kişisel marka ve ajans web sitesi.",
                    Image = "byroot-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 1)
                },
                new Project
                {
                    ProjectId = 2,
                    Title = "CarApp",
                    Description = "Araç listeleme, filtreleme, ilan yönetimi ve admin panel yapısına sahip otomobil projesi.",
                    Image = "carapp-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 5)
                },
                new Project
                {
                    ProjectId = 3,
                    Title = "QrMenu",
                    Description = "Restoranlar için kategori, ürün ve görsel yönetimi bulunan dinamik QR menü uygulaması.",
                    Image = "qrmenu-project.jpg",
                    PublishedOn = new DateTime(2026, 6, 10)
                },
                new Project
                {
                    ProjectId = 4,
                    Title = "Landing Pages",
                    Description = "Kişisel marka, blog, portfolyo ve kurumsal tanıtım sayfaları için modern, sade ve responsive web sayfası tasarımları.",
                    Image = "landing-pages.jpg",
                    PublishedOn = new DateTime(2026, 6, 15)
                }
            );
        }
    }
}