using Microsoft.EntityFrameworkCore;
using MyBlog.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<IdentityContex>(options =>
{
    var config = builder.Configuration;
    var constr = config.GetConnectionString("mysql_connection");

    var version = new MySqlServerVersion(new Version(8, 0, 46));
    options.UseMySql(constr, version);
});



// builder.Services.AddDbContext<IdentityContex>(options =>
// {
//     var connectionString = builder.Configuration.GetConnectionString("mysql_connection");

//     options.UseMySql(
//         connectionString,
//         ServerVersion.AutoDetect(connectionString)
//     );
// });

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<IdentityContex>();
    db.Database.Migrate();
}

app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();