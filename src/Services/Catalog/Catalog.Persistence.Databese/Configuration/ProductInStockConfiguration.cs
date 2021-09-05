using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Databese.Configuration
{
    class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ProductInStockId);

            var products = new List<ProductInStock>();
            var randon = new Random();

            for (var i = 1; i <= 100; i++)
            {
                products.Add(new ProductInStock
                {
                        ProductInStockId = i,
                        ProductId = 1,
                        Stock = randon.Next(0, 100)
                });
            }

            entityBuilder.HasData(products);
        }
    }
}
