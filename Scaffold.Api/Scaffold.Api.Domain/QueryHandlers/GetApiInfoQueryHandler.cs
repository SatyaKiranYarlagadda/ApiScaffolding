using System.Threading;
using System.Threading.Tasks;
using Scaffold.Api.Domain.Models;
using Scaffold.Api.Domain.Queries;
using MediatR;

namespace Scaffold.Api.Domain.QueryHandlers
{
    public class GetApiInfoQueryHandler : IRequestHandler<GetApiInfoQuery, ApiInfo>
    {
        public async Task<ApiInfo> Handle(GetApiInfoQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new ApiInfo
            {
                ApiName = "[TBD-ApiName]",
                ApiVersion = "[TBD-ApiVersion]"
            });
        }
    }
}
