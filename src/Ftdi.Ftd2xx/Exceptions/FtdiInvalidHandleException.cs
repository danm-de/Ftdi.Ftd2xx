using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiInvalidHandleException : FtdiException {
        public FtdiInvalidHandleException() { }
        public FtdiInvalidHandleException(string message) : base(message) { }
        public FtdiInvalidHandleException(string message, Exception inner) : base(message, inner) { }
        protected FtdiInvalidHandleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
