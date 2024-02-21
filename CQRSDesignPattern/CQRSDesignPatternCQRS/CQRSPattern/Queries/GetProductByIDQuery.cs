using CQRSDesignPatternCQRS.CQRSPattern.Results;
using CQRSDesignPatternCQRS.DAL;

namespace CQRSDesignPatternCQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
