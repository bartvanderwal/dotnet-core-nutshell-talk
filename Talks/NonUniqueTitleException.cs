using System;
using System.Runtime.Serialization;

namespace talks
{
    [Serializable]
    internal class NonUniqueTitleException : Exception
    {
        public NonUniqueTitleException()
        {
        }

        public NonUniqueTitleException(string message) : base(message)
        {
        }

        public NonUniqueTitleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NonUniqueTitleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}