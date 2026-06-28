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
                    Link = "https://github.com/omerapaydin",
                    Description = "Hizmetler, projeler, iletişim ve randevu sistemi içeren kişisel marka ve ajans web sitesi.",
                    Image = "byroot1.jpg",
                    PublishedOn = new DateTime(2026, 6, 1)
                },
                new Project
                {
                    ProjectId = 2,
                    Title = "E-Saat",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin",
                    Description = "Saat ürünleri için kategori, ürün listeleme, detay sayfası, sepet, sipariş oluşturma ve admin panel yönetimi bulunan e-ticaret web uygulaması.",
                    Image = "saat1.jpg",
                    PublishedOn = new DateTime(2026, 6, 5)
                },
                new Project
                {
                    ProjectId = 3,
                    Title = "Siber Güvenlik",
                    CategoryId = 3,
                    Link = "https://github.com/omerapaydin/SiberGuvenlik",
                    Description = "Etik hackerlık, ağ güvenliği, bilgi toplama, zafiyet analizi, XSS, SQL enjeksiyonu, web pentesting, parola hash kırma ve sosyal mühendislik konularını içeren siber güvenlik eğitim notları ve uygulamalı çalışmalar.",
                    Image = "cyber1.jpg",
                    PublishedOn = new DateTime(2026, 6, 10)
                },
                new Project
                {
                    ProjectId = 4,
                    Title = "E-Takı",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin/MyBlog",
                    Description = "Takı ürünleri için kategori filtreleme, ürün listeleme, detay sayfası, sepet, sipariş oluşturma ve admin panel yönetimi bulunan dinamik e-ticaret web uygulaması.",
                    Image = "tak2.jpg",
                    PublishedOn = new DateTime(2026, 6, 15)
                },
                new Project
                {
                    ProjectId = 5,
                    Title = "Psikolog App",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin",
                    Description = "Psikologlar için danışan randevu oluşturma, müsait saat seçimi, iletişim formu ve admin panel üzerinden randevu yönetimi özellikleri bulunan modern web uygulaması.",
                    Image = "psiko1.jpg",
                    PublishedOn = new DateTime(2026, 6, 18)
                },
                new Project
                {
                    ProjectId = 6,
                    Title = "QrMenü",
                    CategoryId = 1,
                    Link = "https://github.com/omerapaydin",
                    Description = "Restoran ve kafeler için kategori, ürün, fiyat ve görsel yönetimi bulunan; müşterilerin QR kod üzerinden menüye kolayca ulaşmasını sağlayan dinamik web uygulaması.",
                    Image = "qr.jpg",
                    PublishedOn = new DateTime(2026, 6, 20)
                },
                new Project
                {
                    ProjectId = 7,
                    Title = "Project Management Case",
                    CategoryId = 4,
                    Link = "https://github.com/omerapaydin/AgileProjeYonetimi",
                    Description = "Proje planlama, ihtiyaç analizi, görev takibi ve süreç yönetimi odaklı proje yönetimi çalışması.",
                    Image = "agile1.jpg",
                    PublishedOn = new DateTime(2026, 6, 22)
                }
            );
        }
    }
}