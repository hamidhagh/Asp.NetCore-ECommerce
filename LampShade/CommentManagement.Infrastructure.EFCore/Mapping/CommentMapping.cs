﻿using CommentManagement.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentManagement.Infrastructure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Type);
            builder.Property(x => x.ParentId).HasDefaultValue(0);
            builder.Property(x => x.OwnerRecordId);
            builder.Property(x => x.IsCanceled);
            builder.Property(x => x.IsConfirmed);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Email).HasMaxLength(500);
            builder.Property(x => x.Website).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Message).HasMaxLength(1000);
            builder.Property(x => x.CreationDate);
        }
    }
}
