using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiInvalidParameterException : FtdiException {
        public FtdiInvalidParameterException() { }
        public FtdiInvalidParameterException(string message) : base(message) { }
        public FtdiInvalidParameterException(string message, Exception inner) : base(message, inner) { }
        protected FtdiInvalidParameterException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
