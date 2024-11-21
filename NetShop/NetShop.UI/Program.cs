using NetShop.Application;
using Microsoft.EntityFrameworkCore;
using NetShop.Infrastucture;
using NetShop.Infrastucture.MappingConfig;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Configuration
.AddJsonFile($"appsettings.json", optional: false)
.AddJsonFile($"appsettings.Environment.json", optional: true)
.AddEnvironmentVariables()
.Build();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<NetShopDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConneection")));
builder.Services.RegistrationRepositories();
builder.Services.RegistrationServices();
builder.Services.RegistrationAutoMapper();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.Run();
