using NetShop.Application;
using Microsoft.EntityFrameworkCore;
using NetShop.Infrastucture;
using NetShop.Application.MappingConfig;
using Swashbuckle.AspNetCore;
using Microsoft.AspNetCore.Builder;
using NetShop.UI.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Configuration
.AddJsonFile($"appsettings.json", optional: false)
.AddJsonFile($"appsettings.Environment.json", optional: true)
.AddEnvironmentVariables()
.Build();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<NetShopDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConneection")));
builder.Services.RegistrationLogger();
builder.Services.RegistrationAutoMapper();
builder.Services.RegistrationRepositories();
builder.Services.RegistrationServices();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.UseAllOfForInheritance();
    swaggerGenOptions.UseOneOfForPolymorphism();

    swaggerGenOptions.SelectSubTypesUsing(baseType => typeof(Program).Assembly.GetTypes().Where(type => type.IsSubclassOf(baseType))
    );
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapSwagger();

app.MapControllers();
app.Run();
