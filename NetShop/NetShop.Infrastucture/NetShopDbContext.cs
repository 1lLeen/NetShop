using Microsoft.EntityFrameworkCore;
using NetShop.Infrastucture.ModelConfiguration;
using NetShop.Infrastucture.Models;
using NetShop.Infrastucture.Models.Categories;
using NetShop.Infrastucture.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture
{
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
    }
}
