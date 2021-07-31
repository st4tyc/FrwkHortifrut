using FrwkHortifrut.Data.Database;
using FrwkHortifrut.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FrwkHortifrut.Service
{
    public static class DIExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<IFrutaRepository, FrutaRepository>();          
            services.AddTransient<IDatabaseBoostrap, DatabaseBoostrap>();

        }
    }
}
