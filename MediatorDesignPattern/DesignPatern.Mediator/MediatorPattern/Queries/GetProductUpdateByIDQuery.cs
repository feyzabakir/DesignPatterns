using DesignPatern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery: IRequest<UpdateProductByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
