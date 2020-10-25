using System;
using System.Runtime.Serialization;

namespace HB.Rover.Infrastructure.Exceptions
{
    public abstract class BaseException : Exception
    {
        protected BaseException()
        {
        }

        protected BaseException(Exception innerException)
            : base(null, innerException)
        {
        }

        protected BaseException(string message)
            : base(message)
        {
        }

        protected BaseException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        protected BaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
