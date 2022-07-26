using ProjectECommerce.Core.DTOs;
using FluentValidation;

namespace ProjectECommerce.Service.Validations
{
    public class CreateOrderRequestDtoValidator : AbstractValidator<CreateOrderRequestDto>
    {
        public CreateOrderRequestDtoValidator()
        {
            RuleFor(x => x.CustomerGSM).NotNull().WithMessage("{PropertyName} is required.").NotEmpty().WithMessage("{PropertyName} is required.").Length(11).WithMessage("{PropertyName} must have 11 characters.");
            RuleFor(x => x.CustomerName).NotNull().WithMessage("{PropertyName} is required.").NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.CustomerEMail).NotNull().WithMessage("{PropertyName} is required.").NotEmpty().WithMessage("{PropertyName} is required.").EmailAddress().WithMessage("{PropertyName} is not exist.");
        }
    }
}
