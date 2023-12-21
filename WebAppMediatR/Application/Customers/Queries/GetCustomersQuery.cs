using MediatR;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Queries
{
    public class GetCustomersQuery : IRequest<List<Customer>>
    {
    }
}
