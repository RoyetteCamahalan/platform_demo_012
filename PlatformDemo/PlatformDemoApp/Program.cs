using Microsoft.EntityFrameworkCore;
using PlatformDemoLib.Data;
using PlatformDemoLib.Services.Interface;
using PlatformDemoLib.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Set Connection String from appsetting.json

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"),
    x => x.MigrationsAssembly("PlatformDemoApp")));

//Register Interface and Repo
builder.Services.AddScoped<ICustomerService, CustomerRepository>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
