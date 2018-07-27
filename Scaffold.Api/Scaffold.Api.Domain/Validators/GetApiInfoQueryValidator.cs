using FluentValidation;
using Scaffold.Api.Domain.Queries;

namespace Scaffold.Api.Domain.Validators
{
    public class GetApiInfoQueryValidator : AbstractValidator<GetApiInfoQuery>
    {
        public GetApiInfoQueryValidator()
        {
            RuleFor(query => query.IsValid).NotNull().Must(x => x == true);
        }
    }
}
