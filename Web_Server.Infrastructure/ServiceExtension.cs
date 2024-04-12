using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Server.Core.Interfaces;
using Web_Server.Infrastructure.Data;

namespace Web_Server.Infrastructure
{
    public static class ServiceExtension
    {
        public static void AddDBContext(this IServiceCollection service, string connection)
        {
            service.AddDbContext<DataBaseContext>(options =>
            {
                options.UseSqlite(connection);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
        public static void AddRepository(this IServiceCollection service)
        {
            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }

    }
}
