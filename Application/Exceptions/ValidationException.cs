using FluentValidation.Results;

namespace Application.Exceptions;
public class ValidationException : Exception
{
    public ValidationException() : base("One or more validation error has occured")
    {
        Errors = new List<string>();
    }

    public List<string> Errors { get; }
    public ValidationException(IEnumerable<ValidationFailure> failtures) : this()
    {
        foreach (var failure in failtures)
        {
            Errors.Add(failtures.First().ErrorMessage);
        }
    }

}
