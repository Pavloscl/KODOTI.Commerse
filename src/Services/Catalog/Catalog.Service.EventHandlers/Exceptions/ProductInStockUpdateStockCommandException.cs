using System;

namespace Catalog.Service.EventHandlers.Exceptions
{
    class ProductInStockUpdateStockCommandException : Exception
    {
        public ProductInStockUpdateStockCommandException(string message) : base(message) { }
    }
}
