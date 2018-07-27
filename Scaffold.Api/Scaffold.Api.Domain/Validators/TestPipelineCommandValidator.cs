using FluentValidation;
using Scaffold.Api.Domain.Commands;

namespace Scaffold.Api.Domain.Validators
{
    public class TestPipelineCommandValidator : AbstractValidator<TestPipelineCommand>
    {
        public TestPipelineCommandValidator()
        {
            RuleFor(query => query.IsValid).NotNull().Must(x => x == true);
        }
    }
}
