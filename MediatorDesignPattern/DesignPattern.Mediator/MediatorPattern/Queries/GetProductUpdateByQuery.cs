using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
