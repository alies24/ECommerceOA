using ECommerce_OA.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_CreateProduct>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Not null!").
                MaximumLength(100).MinimumLength(2).WithMessage("Enter a value between 2 and 100!");

            RuleFor(p => p.UnitsInStock).NotEmpty().NotNull().WithMessage("Not null!").Must(s => s >= 0).WithMessage("Enter a value high from 0!");

            RuleFor(p => p.UnitPrice).NotNull().NotEmpty().Must(s => s >= 0).WithMessage("Enter a value high from 0!");

        }
    }
}
