using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiIncorrectDeviceException : FtdiException
    {
        public FtdiIncorrectDeviceException()
        {
        }

        public FtdiIncorrectDeviceException(string message) : base(message)
        {
        }

        public FtdiIncorrectDeviceException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiIncorrectDeviceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
