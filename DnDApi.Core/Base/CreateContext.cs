using DnDApi.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApi.Core
{
    public class CreateContext
    {
        public static void AddContext(IServiceCollection service, String context) {
            service.AddDbContext<Context>(options => options.UseSqlServer(context));
        }
    }
}
