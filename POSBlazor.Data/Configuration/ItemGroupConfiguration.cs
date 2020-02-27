using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSBlazor.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSBlazor.Data.Configuration
{
    public class ItemGroupConfiguration : IEntityTypeConfiguration<ItemGroup>
    {
        public void Configure(EntityTypeBuilder<ItemGroup> builder)
        {
            builder.ToTable("ItemGroups");
            builder.HasKey(x => x.Id);
        }
    }
}
