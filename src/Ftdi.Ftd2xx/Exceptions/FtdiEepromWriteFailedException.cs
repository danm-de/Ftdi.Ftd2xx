using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions {
    [Serializable]
    public class FtdiEepromWriteFailedException : FtdiException {
        public FtdiEepromWriteFailedException() { }
        public FtdiEepromWriteFailedException(string message) : base(message) { }
        public FtdiEepromWriteFailedException(string message, Exception inner) : base(message, inner) { }
        protected FtdiEepromWriteFailedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
