using FluentValidation;
using WebAppMediatR.Domain;

namespace WebAppMediatR.Infrastructure.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        //public CustomerValidator(IValidator<AddressModel> addressValidator)
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.FirstName).Length(20, 250);
            RuleFor(x => x.LastName).Length(20, 250);
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Please specify a phone number.");
            RuleFor(x => x.Age).InclusiveBetween(18, 60);

            // Complex Properties
            //RuleFor(x => x.Address).SetValidator(addressValidator);
            //RuleFor(x => x.Address).SetValidator(new AddressValidator());
            //RuleFor(x => x.Address).InjectValidator();

            // Collections of Complex Types
            //RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        }
    }
}



// https://docs.fluentvalidation.net/en/latest/
// https://docs.fluentvalidation.net/en/latest/start.html#complex-properties

