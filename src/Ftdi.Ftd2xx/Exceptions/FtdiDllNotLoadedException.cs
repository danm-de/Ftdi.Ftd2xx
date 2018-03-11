using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiDllNotLoadedException : FtdiException
    {
        public FtdiDllNotLoadedException()
        {
        }

        public FtdiDllNotLoadedException(string message) : base(message)
        {
        }

        public FtdiDllNotLoadedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiDllNotLoadedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
