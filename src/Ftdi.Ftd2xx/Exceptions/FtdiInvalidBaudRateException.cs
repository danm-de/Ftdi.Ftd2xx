using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiInvalidBaudRateException : FtdiException
    {
        public FtdiInvalidBaudRateException()
        {
        }

        public FtdiInvalidBaudRateException(string message) : base(message)
        {
        }

        public FtdiInvalidBaudRateException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiInvalidBaudRateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
