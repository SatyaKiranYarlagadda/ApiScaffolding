using HCF.Common.Foundation.ExceptionHandling;

namespace Scaffold.Api.Domain.Exceptions
{
    public class TestException : DomainException
    {
        public TestException()
            : base("This is a test exception.")
        {
        }
    }
}
