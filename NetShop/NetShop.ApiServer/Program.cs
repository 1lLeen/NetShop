 using Microsoft.EntityFrameworkCore;
using NetShop.Application.MappingConfig;
using NetShop.Infrastucture;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
.AddJsonFile($"appsettings.json", optional: false)
.AddJsonFile($"appsettings.Environment.json", optional: true)
.AddEnvironmentVariables()
.Build();

builder.Services.AddDbContext<NetShopDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
#region AddRegistration
builder.Services.RegistrationLogger();
builder.Services.RegistrationAutoMapper();
builder.Services.RegistrationRepositories();
builder.Services.RegistrationServices(); 
#endregion

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "API WSVAP (WebSmartView)", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This 
    c.EnableAnnotations();
});


builder.Services.AddControllers(); 

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
}
 

app.UseHttpsRedirection();

app.MapControllers();

app.Run();