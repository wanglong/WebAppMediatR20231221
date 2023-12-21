using MediatR;
using WebAppMediatR.Data;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Queries
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomerByIdQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var res = await _repository.GetAllAsync(cancellationToken);
            return res.FirstOrDefault();
        }
    }
}
