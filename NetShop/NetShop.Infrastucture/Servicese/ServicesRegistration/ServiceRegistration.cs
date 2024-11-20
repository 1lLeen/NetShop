using Microsoft.Extensions.DependencyInjection;
using NetShop.Infrastucture.Servicese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.Servicese.ServicesRegistration
{
    public static class ServiceRegistration
    {
        public static void RegistrationServices(this ServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
