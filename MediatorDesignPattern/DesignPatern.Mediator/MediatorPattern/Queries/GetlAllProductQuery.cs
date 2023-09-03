using DesignPatern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatern.Mediator.MediatorPattern.Queries
{
    public class GetlAllProductQuery : IRequest<List<GelAllProductQueryResult>>
    {
    }
}
