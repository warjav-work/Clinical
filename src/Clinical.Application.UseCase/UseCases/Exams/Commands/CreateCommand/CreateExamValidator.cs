using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical.Application.UseCase.UseCases.Exams.Commands.CreateCommand
{
    public class CreateExamValidator:AbstractValidator<CreateExamCommand>
    {
        public CreateExamValidator() 
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("El campo Nombre no puede ser nulo.")
                .NotEmpty().WithMessage("El campo Nombre no puede ser vacío.");
        }

    }
}
