using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiInvalidArgsException : FtdiException
    {
        public FtdiInvalidArgsException()
        {
        }

        public FtdiInvalidArgsException(string message) : base(message)
        {
        }

        public FtdiInvalidArgsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiInvalidArgsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
