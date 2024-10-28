using Microsoft.EntityFrameworkCore;
using Project_BookShop;

var builder = WebApplication.CreateBuilder(args);

// Connection string for SQL Server
string connectionString = "Server=DESKTOP-AHDNE2G\\SQLEXPRESS;Database=schoolDB;Trusted_Connection=True;TrustServerCertificate=True";

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BookDb_Context>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Use HSTS for production scenarios
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
