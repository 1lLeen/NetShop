using Microsoft.EntityFrameworkCore;
using NetShop.Infrastucture.ModelConfiguration;
using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Models.Products;

namespace NetShop.Infrastucture;

public class NetShopDbContext:DbContext
{
    public DbSet<ProductModel> Products { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }
    public NetShopDbContext() { }
    public NetShopDbContext(DbContextOptions<NetShopDbContext> options) : base(options) { }
        
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 
        modelBuilder.ApplyConfiguration(new BaseConfiguration<ProductModel>());
        modelBuilder.ApplyConfiguration(new BaseConfiguration<CategoryModel>());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=LAPTOP-JGD7BPIQ\\MSSQLSERVER12;Initial Catalog=netshopdb;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");
    }
}