using MediatR;

namespace Catalog.Service.EventHandlers.Commands
{
    public class ProductCreateCommand : INotification
    {
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public decimal Price { get; set; }
    }
}
