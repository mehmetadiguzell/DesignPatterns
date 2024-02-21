using CQRSDesignPatternCQRS.CQRSPattern.Queries;
using CQRSDesignPatternCQRS.CQRSPattern.Results;
using CQRSDesignPatternCQRS.DAL;

namespace CQRSDesignPatternCQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Products.Find(query.ID);
            return new GetProductByUpdateQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock,  
            };
        }
    }
}
