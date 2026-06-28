using Microsoft.EntityFrameworkCore;
using MyBlog.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContex>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection")));


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
