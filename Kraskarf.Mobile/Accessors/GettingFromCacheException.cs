using System;
using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Accessors
{
    public class GettingFromCacheException : Exception
    {
        public GettingFromCacheException()
        {
        }

        public GettingFromCacheException(string message) : base(message)
        {
        }

        public GettingFromCacheException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GettingFromCacheException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}