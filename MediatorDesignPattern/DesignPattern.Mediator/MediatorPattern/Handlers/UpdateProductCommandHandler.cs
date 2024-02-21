using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductID);
            values.ProductName = request.ProductName;
            values.ProductPrice = request.ProductPrice;
            values.ProductCategory = request.ProductCategory;
            values.ProductStock = request.ProductStock;
            values.ProductStockType = request.ProductStockType;
            await _context.SaveChangesAsync();
        }
    }
}
