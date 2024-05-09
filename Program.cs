using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BlogContext>(options =>{options.UseSqlite(builder.Configuration["ConnectionStrings:sql_connection"]);});

builder.Services.AddScoped<IUserRepository,EfUserRepository>();
builder.Services.AddScoped<ICommentRepository,EfCommentRepository>();
builder.Services.AddScoped<IPostRepository, EfPostRepository>();

var app = builder.Build();

app.UseRouting();


app.UseStaticFiles();

SeedData.TestVerileriniDoldur(app);


app.MapControllerRoute(
        name:"post_details",
        pattern: "posts/{url}",
        defaults: new {controller= "Posts", action = "Details"}
        );

        
app.MapControllerRoute(
    name : "default",
     pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();
