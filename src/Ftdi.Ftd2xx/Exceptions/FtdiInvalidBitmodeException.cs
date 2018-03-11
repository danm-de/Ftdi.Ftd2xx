using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiInvalidBitmodeException : FtdiException {
        public FtdiInvalidBitmodeException() { }
        public FtdiInvalidBitmodeException(string message) : base(message) { }
        public FtdiInvalidBitmodeException(string message, Exception inner) : base(message, inner) { }
        protected FtdiInvalidBitmodeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
