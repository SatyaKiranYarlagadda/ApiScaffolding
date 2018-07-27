using System.Threading.Tasks;
using Scaffold.PassThroughApi.Api.Models.Response.ApiInfo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Scaffold.PassThroughApi.Api.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ApiInfoController : ControllerBase
    {
        private readonly ILogger<ApiInfoController> _logger;

        public ApiInfoController(ILogger<ApiInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("info")]
        public async Task<ApiInfo> Get()
        {
            _logger.LogInformation("Get Api info.");

            return await Task.FromResult(new ApiInfo
            {
                ApiName = "[TBD-ApiName]",
                ApiVersion = "[TBD-ApiVersion]"
            });
        }
    }
}
