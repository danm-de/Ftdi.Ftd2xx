using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiEepromReadFailedException : FtdiException {
        public FtdiEepromReadFailedException() { }
        public FtdiEepromReadFailedException(string message) : base(message) { }
        public FtdiEepromReadFailedException(string message, Exception inner) : base(message, inner) { }
        protected FtdiEepromReadFailedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
