using CQRSDesignPatternCQRS.CQRSPattern.Queries;
using CQRSDesignPatternCQRS.CQRSPattern.Results;
using CQRSDesignPatternCQRS.DAL;

namespace CQRSDesignPatternCQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name=values.Name,
                Price=values.Price,
                ProductID=values.ProductID,
                Stock=values.Stock
            };
        }
    }
}
