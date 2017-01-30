using System;
using System.Runtime.Serialization;

namespace StringKata2
{
    public class NegativesException : Exception
    {
        public NegativesException()
        {
        }

        public NegativesException(string message) : base(message)
        {
        }

        public NegativesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}