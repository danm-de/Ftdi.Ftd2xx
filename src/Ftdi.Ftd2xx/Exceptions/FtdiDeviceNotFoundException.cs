using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiDeviceNotFoundException : FtdiException {
        public FtdiDeviceNotFoundException() { }
        public FtdiDeviceNotFoundException(string message) : base(message) { }
        public FtdiDeviceNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected FtdiDeviceNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
