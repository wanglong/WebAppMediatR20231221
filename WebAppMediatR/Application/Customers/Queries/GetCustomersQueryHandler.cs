using MediatR;
using WebAppMediatR.Data;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Queries
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomersQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var res = await _repository.GetAllAsync(cancellationToken);
            return res.ToList();
        }
    }
}
