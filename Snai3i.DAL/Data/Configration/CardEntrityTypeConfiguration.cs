﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Snai3i.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i.DAL.Data.Configration
{
    public class CardEntrityTypeConfiguration : IEntityTypeConfiguration<Card>
    {

        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasOne(e => e.Sale).
            WithOne(e => e.card).
            HasPrincipalKey<Card>(e => e.SaleId)
            .HasForeignKey<Sales>(e => e.CardId).
            IsRequired();

            builder.HasOne(e => e.buyer).
                WithMany(e => e.cards).
                HasForeignKey(e => e.BuyerId).
                IsRequired(); 


            builder.Property(a => a.Isdeleted)
               .HasDefaultValue(false);

            builder.HasQueryFilter(a => a.Isdeleted == false);
        }
    }
}
