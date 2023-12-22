using FluentValidation;

namespace Application.Features.Clients.Commands.CreateClientsCommand;
public class CreateClientsCommandValidator : AbstractValidator<CreateClientsCommand>
{
    public CreateClientsCommandValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().WithMessage("{PropertyName} can't be empty")
            .MaximumLength(80).WithMessage("{PropertyName} shouldn't exceed {MaxLength} characters");

        RuleFor(p => p.LastName).NotEmpty().WithMessage("{PropertyName} can't be empty")
         .MaximumLength(80).WithMessage("{PropertyName} shouldn't exceed {MaxLength} characters");

        RuleFor(p => p.DateOfBirth).NotEmpty().WithMessage("{PropertyName} can't be empty");

        RuleFor(p => p.PhoneNumber).NotEmpty().WithMessage("{PropertyName} can't be empty")
            .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} it must comply with format 0000-0000")
         .MaximumLength(9).WithMessage("{PropertyName} shouldn't exceed {MaxLength} characters");


        RuleFor(p => p.Email).NotEmpty().WithMessage("{PropertyName} can't be empty")
    .EmailAddress().WithMessage("{PropertyName} must be a valid email address")
 .MaximumLength(100).WithMessage("{PropertyName} shouldn't exceed {MaxLength} characters");


        RuleFor(p => p.Address).NotEmpty().WithMessage("{PropertyName} can't be empty")
            .MaximumLength(120).WithMessage("{PropertyName} shouldn't exceed {MaxLength} characters");

    }
}
