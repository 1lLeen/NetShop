using Microsoft.Extensions.DependencyInjection;
using NetShop.Infrastucture.Repositories.Interfaces;
using NetShop.Infrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetShop.Application.Servicese.Interfaces;
using NetShop.Application.Servicese;
using Microsoft.Extensions.Logging;

namespace NetShop.Application.MappingConfig
{
    public static class Registration
    {
        public static void RegistrationLogger(this IServiceCollection services) 
        {
            var serviceProvider = services.BuildServiceProvider();
            var loggerProduct = serviceProvider.GetRequiredService<ILogger<ProductService>>();
            var loggerCategory = serviceProvider.GetRequiredService<ILogger<CategoryService>>();
            services.AddSingleton(typeof(ILogger), loggerProduct);
            services.AddSingleton(typeof(ILogger), loggerCategory);
        }
        public static void RegistrationRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepoistory>();
            services.AddTransient<IProductRepository, ProductRepoistory>();

        }
        public static void RegistrationServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}
