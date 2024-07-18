using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Repository.Impl;
using OnlineShopping.Repository.Interface;
using OnlineShopping.Service.Impl;
using OnlineShopping.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddScoped<IAccountRepository, AccountRepository>();
services.AddScoped<IProductRepository, ProductRepository>();
services.AddScoped<IAccountService, AccountService>();
services.AddScoped<IProductService, ProductService>();
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
