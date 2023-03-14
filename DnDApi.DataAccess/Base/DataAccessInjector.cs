using DnDApi.DataAccess.Source;
using Microsoft.Extensions.DependencyInjection;

namespace DnDApi.DataAccess
{
    public class DataAccessInjector
    {
        public static void Create(IServiceCollection service) {
            service.AddTransient<ClassDataAccess>();
            service.AddTransient<RaceDataAccess>();
        }
    }
}
