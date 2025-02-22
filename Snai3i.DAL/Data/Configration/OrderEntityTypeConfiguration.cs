﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Snai3i.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i.DAL.Data.Configration
{
    public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(e => e.review)
                .WithOne(e => e.order).
                HasPrincipalKey<Order>(e => e.reviewId)
                .HasForeignKey<Review>(e => e.OrderId)
                .IsRequired(); 

            builder.Property(a => a.Isdeleted)
           .HasDefaultValue(false);

            builder.HasQueryFilter(a => a.Isdeleted == false);
        }
    }
}