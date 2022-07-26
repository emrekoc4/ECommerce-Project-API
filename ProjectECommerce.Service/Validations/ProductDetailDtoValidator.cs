using ProjectECommerce.Core.DTOs;
using FluentValidation;

namespace ProjectECommerce.Service.Validations
{
    public class ProductDetailDtoValidator : AbstractValidator<ProductDetailDto>
    {
        public ProductDetailDtoValidator()
        {
            RuleFor(x => x.Amount).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("{PropertyName} must be greater than 0");
            RuleFor(x => x.Id).LessThan(1001).WithMessage("{PropertyName} must be smaller than 1001");
        }
    }
}
