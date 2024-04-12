using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Server.Core.Entity;
using Web_Server.Infrastructure.EntitiesConfiguration;


namespace Web_Server.Infrastructure.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
