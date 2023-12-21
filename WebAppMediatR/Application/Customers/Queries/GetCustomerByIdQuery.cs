using MediatR;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
