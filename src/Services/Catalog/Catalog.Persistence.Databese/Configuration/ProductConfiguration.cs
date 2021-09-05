using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Databese.Configuration
{
    class ProductConfiguration
    {
      public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(500);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(500);

            //Product by default

            var products = new List<Product>();
            var randon = new Random();

            for (var i = 1; i <= 100; i++)
            {
                products.Add(new Product
                { 
                    ProductId=i,
                    Name=$"Product{i}",
                    Descripcion=$"Description for product {i}",
                    Price= randon.Next(100,1000)
                });
            }

            entityBuilder.HasData(products);

       }
    }
}
