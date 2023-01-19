using FluentValidation;
using GebruikersbeheerZvz.Handlers.Commands;
using MediatR;

namespace GebruikersbeheerZvz.Handlers.Validator
{
    // creeer een mediatr pipeline behavior voor Fluent Migrations
    public class ValidatorPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : ICommand<TResponse>
    { 
        private readonly IValidator<TRequest> validator;

        public ValidatorPipelineBehavior(IValidator<TRequest> validator)
        {
            this.validator = validator;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var result = await validator.ValidateAsync(request, cancellationToken);
            
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            return await next();
        }
    }
}
