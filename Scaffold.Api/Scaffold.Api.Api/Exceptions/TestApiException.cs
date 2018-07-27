using System;
using System.Runtime.Serialization;
using HCF.Common.Foundation.ExceptionHandling;
using HCF.Common.Foundation.ResponseObjects;

namespace Scaffold.Api.Api.Exceptions
{
    public class TestApiException : InternalServerErrorApiException
    {
        public TestApiException(string message, ApiErrorResponse<object> errorDetails = null) : base(message, errorDetails)
        {
        }

        public TestApiException(string message, Exception innerException, ApiErrorResponse<object> errorDetails = null) : base(message, innerException, errorDetails)
        {
        }

        protected TestApiException(SerializationInfo info, StreamingContext context, ApiErrorResponse<object> errorDetails = null) : base(info, context, errorDetails)
        {
        }
    }
}
