using Child.Infrasructure.Adapters.PersonService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child.Infrasructure
{
    public static class InfrasructureServiceRegistiration
    {
        public static IServiceCollection AddInfrasructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IKpsService, KpsServiceManager>();
            return services;
        }
    }
}
