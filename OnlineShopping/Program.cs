using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;


services.AddControllersWithViews();
services.AddDbContext<OnlineShoppingDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("Default"));
});
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
