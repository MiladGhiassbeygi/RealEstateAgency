﻿using CleanArc.Domain.Entities.EstateFiling;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Infrastructure.Persistence.Configuration.EstateFilingConfig
{
    internal class EstateConfig : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {
            builder.HasOne(c => c.EstateType)
                .WithMany(c => c.Estates)
                .HasForeignKey(c => c.EstateTypeId);


            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
