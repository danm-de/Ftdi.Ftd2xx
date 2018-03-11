using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiFailedToWriteDeviceException : FtdiException
    {
        public FtdiFailedToWriteDeviceException()
        {
        }

        public FtdiFailedToWriteDeviceException(string message) : base(message)
        {
        }

        public FtdiFailedToWriteDeviceException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiFailedToWriteDeviceException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }
    }
}
