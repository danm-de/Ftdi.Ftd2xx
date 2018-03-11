using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiDeviceNotOpenedException : FtdiException
    {
        public FtdiDeviceNotOpenedException()
        {
        }

        public FtdiDeviceNotOpenedException(string message) : base(message)
        {
        }

        public FtdiDeviceNotOpenedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiDeviceNotOpenedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
