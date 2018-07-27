using HCF.Common.Foundation.CQRSExtensions;
using MediatR;

namespace Scaffold.Api.Domain.Commands
{
    public class TestPipelineCommand : IRequest<ICommandResult>
    {
        public bool? IsValid { get; set; }
    }
}
