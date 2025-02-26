﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetShop.Infrastucture.Models;

namespace NetShop.Infrastucture.ModelConfiguration;

public class BaseConfiguration<TModel> : IEntityTypeConfiguration<TModel> where TModel : BaseModel
{
    public void Configure(EntityTypeBuilder<TModel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
    public static void InitDefaultDateColumns(EntityTypeBuilder<TModel> builder)
    {
        builder.Property(x => x.CreatedTime)
            .IsRequired()
            .ValueGeneratedOnAdd()
            .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);

        builder.Property(x => x.UpdatedTime)
            .IsRequired()
            .ValueGeneratedOnAddOrUpdate()
            .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
    }
}
