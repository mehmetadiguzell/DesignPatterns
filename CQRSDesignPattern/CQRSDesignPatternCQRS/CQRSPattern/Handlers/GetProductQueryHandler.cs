using CQRSDesignPatternCQRS.CQRSPattern.Results;
using CQRSDesignPatternCQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CQRSDesignPatternCQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=>new GetProductQueryResult
            {
                ID=x.ProductID,
                Price=x.Price,
                ProductName=x.Name,
                Stock=x.Stock
            }).ToList();
            return values;
        }
    }
}
