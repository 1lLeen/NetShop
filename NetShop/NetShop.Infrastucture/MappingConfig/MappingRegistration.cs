using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Infrastucture.MappingConfig
{
    public static class MappingRegistration
    {
        public static void RegistrationAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
