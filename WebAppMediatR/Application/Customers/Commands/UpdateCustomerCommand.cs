using MediatR;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Commands
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
