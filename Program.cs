using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using proyecto_santiago.Data;
using proyecto_santiago.implementación;
using proyecto_santiago.services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Defaultonnetions");

// Add services to the container.

builder.Services.AddDbContext<DBContex>(Options => Options.UseNpgsql(connectionString));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPawordServicio, PasswordServicio>();
builder.Services.AddScoped<ILoginServicio, LoginServicio>(); 


builder.Services.AddControllersWithViews();

var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
      app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

//app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
     name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();