using Microsoft.EntityFrameworkCore;
using PlatformDemoLib.Data;
using PlatformDemoLib.Services.Interface;
using PlatformDemoLib.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"),
    x => x.MigrationsAssembly("PlatformDemoApp")));

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
