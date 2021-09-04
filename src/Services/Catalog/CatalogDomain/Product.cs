namespace Catalog.Domain
{
    class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Descripcion { get; set; }

        public decimal Price { get; set; }

        public ProductInStock Stock { get; set; }
    }
}
