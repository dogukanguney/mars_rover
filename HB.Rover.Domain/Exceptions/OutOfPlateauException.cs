using HB.Rover.Infrastructure.Exceptions;
using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace HB.Rover.Domain.Exceptions
{
    public class OutOfPlateauException : BaseException
    {
        public OutOfPlateauException()
        {
        }

        public OutOfPlateauException(Exception innerException)
            : base(null, innerException)
        {
        }

        public OutOfPlateauException(string message)
            : base(message)
        {
        }

        public OutOfPlateauException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected OutOfPlateauException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
