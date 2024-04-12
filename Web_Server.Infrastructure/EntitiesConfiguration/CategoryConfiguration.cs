using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Server.Core.Entity;

namespace Web_Server.Infrastructure.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            //Set Primary Key
            builder.HasKey(c => c.Id);

            //Set Property configurations
            builder.Property(c => c.Name)
                   .HasMaxLength(256)
                   .IsRequired();

        }

    }
}
