using Scaffold.Api.Domain.Models;
using MediatR;

namespace Scaffold.Api.Domain.Queries
{
    public class GetApiInfoQuery : IRequest<ApiInfo>
    {
        public bool? IsValid { get; set; }
    }
}
