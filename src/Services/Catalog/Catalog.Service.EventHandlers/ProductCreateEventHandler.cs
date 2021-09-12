using Catalog.Domain;
using Catalog.Persistence.Databese;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventHandler :
        INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Name = notification.Name,
                Descripcion = notification.Descripcion,
                Price = notification.Price
            });

            await _context.SaveChangesAsync();
        }
    }

}
