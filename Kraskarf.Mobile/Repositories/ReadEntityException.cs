using System;
using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Repositories
{
    public class ReadEntityException : Exception
    {
        public ReadEntityException()
        {
        }

        public ReadEntityException(string message) : base(message)
        {
        }

        public ReadEntityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReadEntityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}