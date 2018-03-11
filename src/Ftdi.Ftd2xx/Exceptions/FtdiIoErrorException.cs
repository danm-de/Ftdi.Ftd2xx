using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiIoErrorException : FtdiException {
        public FtdiIoErrorException() { }
        public FtdiIoErrorException(string message) : base(message) { }
        public FtdiIoErrorException(string message, Exception inner) : base(message, inner) { }
        protected FtdiIoErrorException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
