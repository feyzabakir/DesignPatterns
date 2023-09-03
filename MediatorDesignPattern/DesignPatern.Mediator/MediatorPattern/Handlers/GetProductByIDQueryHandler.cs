using DesignPatern.Mediator.DAL;
using DesignPatern.Mediator.MediatorPattern.Queries;
using DesignPatern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatern.Mediator.MediatorPattern.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock
            };
        }
    }
}
