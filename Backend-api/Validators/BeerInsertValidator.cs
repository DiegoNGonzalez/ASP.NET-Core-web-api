using Backend_api.DTOs;
using FluentValidation;

namespace Backend_api.Validators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre no puede estar vacio");
            RuleFor(x=> x.Name).Length(3, 20).WithMessage("El nombre debe tener entre 3 y 20 caracteres");
            RuleFor(x=> x.BrandId).NotNull().WithMessage("La marca es obligatoria");
            RuleFor(x=> x.BrandId).GreaterThan(0).WithMessage("Error con el valor enviado de marca");
            RuleFor(x=> x.Alcohol).GreaterThan(0).WithMessage("El {PropertyName} debe ser mayor a 0");
        }
    }
}
