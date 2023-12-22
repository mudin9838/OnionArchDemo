﻿using FluentValidation;
using MediatR;

namespace Application.Behaviours;
public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(context, cancellationToken)));
            var failtures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failtures.Count != 0)
            {
                throw new Exceptions.ValidationException(failtures);
            }
        }
        return await next();
    }
}
