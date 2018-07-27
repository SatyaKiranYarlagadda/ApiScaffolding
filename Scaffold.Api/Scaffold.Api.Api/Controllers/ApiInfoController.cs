using System;
using System.Threading.Tasks;
using Scaffold.Api.Api.Exceptions;
using Scaffold.Api.Api.Models;
using Scaffold.Api.Domain.Commands;
using Scaffold.Api.Domain.Exceptions;
using Scaffold.Api.Domain.Queries;
using HCF.Common.Foundation.ExceptionHandling;
using HCF.Common.Foundation.ResponseObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Scaffold.Api.Api.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ApiInfoController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ApiInfoController> _logger;

        public ApiInfoController(IMediator mediator, ILogger<ApiInfoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("info")]
        public async Task<ApiInfo> Get()
        {
            _logger.LogInformation("Get Api info.");

            var info = await _mediator.Send(new GetApiInfoQuery
            {
                IsValid = true
            });

            return new ApiInfo
            {
                ApiVersion = info.ApiVersion,
                ApiName = info.ApiName
            };
        }

        [HttpPost("testpipeline")]
        public async Task<IActionResult> TestPipeline()
        {
            _logger.LogInformation("Test Api pipeline.");

            try
            {
                var info = await _mediator.Send(new TestPipelineCommand
                {
                    IsValid = true
                });

                return Ok(info.Result);
            }
            catch (DomainException ex)
            {
                if (ex is TestException)
                {
                    throw new TestApiException("This is a test api exception", new ApiErrorResponse<object>
                    {
                        Message = new [] {"Failed to test api pipeline."},
                        Status = ResponseStatusCode.Error
                    });
                }
                throw;
            }
        }
    }
}
