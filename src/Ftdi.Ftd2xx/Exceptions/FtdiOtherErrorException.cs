using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiOtherErrorException : FtdiException
    {
        public FtdiOtherErrorException()
        {
        }

        public FtdiOtherErrorException(string message) : base(message)
        {
        }

        public FtdiOtherErrorException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiOtherErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
