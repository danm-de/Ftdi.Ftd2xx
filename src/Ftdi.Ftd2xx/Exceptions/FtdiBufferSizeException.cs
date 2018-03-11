using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiBufferSizeException : FtdiException {
        public FtdiBufferSizeException() { }
        public FtdiBufferSizeException(string message) : base(message) { }
        public FtdiBufferSizeException(string message, Exception inner) : base(message, inner) { }
        protected FtdiBufferSizeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
