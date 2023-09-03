using DesignPatern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIDQuery: IRequest<GetProductByIDQueryResult>
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
