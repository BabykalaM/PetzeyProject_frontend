using System.Runtime.Serialization;

namespace Petzey.Dept.Controllers.Tests
{
    public class NotNullException : Exception
    {
        public NotNullException()
        {
        }

        public NotNullException(string? message) : base(message)
        {
        }

        public NotNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}