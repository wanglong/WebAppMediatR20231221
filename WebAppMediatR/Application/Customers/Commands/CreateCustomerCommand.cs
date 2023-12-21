using MediatR;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Application.Customers.Commands
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
