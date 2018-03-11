using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiEepromEraseFailedException : FtdiException {
        public FtdiEepromEraseFailedException() { }
        public FtdiEepromEraseFailedException(string message) : base(message) { }
        public FtdiEepromEraseFailedException(string message, Exception inner) : base(message, inner) { }
        protected FtdiEepromEraseFailedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
