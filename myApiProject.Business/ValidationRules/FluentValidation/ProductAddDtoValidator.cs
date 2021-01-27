using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Dtos.ProductDtos;

namespace myApiProject.Business.ValidationRules.FluentValidation
{
    public class ProductAddDtoValidator : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");
        }
    }
}
