using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiDeviceNotOpenedForEraseException : FtdiException {
        public FtdiDeviceNotOpenedForEraseException() { }
        public FtdiDeviceNotOpenedForEraseException(string message) : base(message) { }
        public FtdiDeviceNotOpenedForEraseException(string message, Exception inner) : base(message, inner) { }
        protected FtdiDeviceNotOpenedForEraseException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
