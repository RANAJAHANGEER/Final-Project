using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Areas.Identity.Data;
using WebApplication11.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("WebApplication11ContextConnection") ?? throw new InvalidOperationException("Connection string 'WebApplication11ContextConnection' not found.");

builder.Services.AddDbContext<WebApplication11Context>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<WebApplication11User>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<WebApplication11Context>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
