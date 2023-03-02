using DnDApi.Core.Source;
using DnDApi.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace DnDApi.Core
{
    public class CoreInjector
    {
        public static void Create(IServiceCollection service) {
            
            service.AddTransient<ClassCore>();

            DataAccessInjector.Create(service);
        }
    }
}
