using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entity;

namespace MyBlog.Data.Concrete.EfCore
{
    public class SeedData
    {
            public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

               

                 if(!context.Users.Any())
                {
                    context.Users.AddRange( 
                       new User{UserName = "omerapaydin",Name="Ömer Apaydın",Email="info@gmail.com",Password="12374321",Image="p1.jpg",},
                      new User{UserName = "ahmettambuga",Name="Ahmet Tambuğa",Email="info2@gmail.com",Password="123456",Image="p2.jpg",}
                       
                    );
                    context.SaveChanges();
                }

                 if(!context.Posts.Any())
                {
                    context.Posts.AddRange( 
                        new Post{
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Image = "1.jpg",
                            Url="aspnet-core",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            UserId = 1,
                            Comments = new List<Comment>{ 
                            new Comment { Text = "Çok havalı",PublishedOn =  DateTime.Now.AddDays(-20),UserId = 1},
                            new Comment { Text = "Çok iyi",PublishedOn =  DateTime.Now.AddDays(-10),UserId = 2},
                            new Comment { Text = "Fena",PublishedOn =  DateTime.Now.AddDays(-10),UserId = 2},
                            }
                            },
                        new Post{
                            Title = "Php",
                            Description = "Php core dersleri",
                            Image = "2.jpg",
                            Url="php",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            UserId = 1
                            },
                        new Post{
                            Title = "Django",
                            Description = "Django dersleri",
                            Image = "3.jpg",
                            Url="django",
                            PublishedOn = DateTime.Now.AddDays(-5),
                            UserId = 2
                            }
                    );
                    context.SaveChanges();
                }




            }

        }

    }
}