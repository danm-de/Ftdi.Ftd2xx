using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiDeviceNotOpenedForWriteException : FtdiException {
        public FtdiDeviceNotOpenedForWriteException() { }
        public FtdiDeviceNotOpenedForWriteException(string message) : base(message) { }
        public FtdiDeviceNotOpenedForWriteException(string message, Exception inner) : base(message, inner) { }
        protected FtdiDeviceNotOpenedForWriteException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
