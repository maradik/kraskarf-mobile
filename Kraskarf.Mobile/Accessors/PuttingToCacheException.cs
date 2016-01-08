using System;
using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Accessors
{
    public class PuttingToCacheException : Exception
    {
        public PuttingToCacheException()
        {
        }

        public PuttingToCacheException(string message) : base(message)
        {
        }

        public PuttingToCacheException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PuttingToCacheException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}