using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiInsufficientResourcesException : FtdiException
    {
        public FtdiInsufficientResourcesException()
        {
        }

        public FtdiInsufficientResourcesException(string message) : base(message)
        {
        }

        public FtdiInsufficientResourcesException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiInsufficientResourcesException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }
    }
}
