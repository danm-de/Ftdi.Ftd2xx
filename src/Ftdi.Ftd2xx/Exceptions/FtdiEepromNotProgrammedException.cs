using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiEepromNotProgrammedException : FtdiException
    {
        public FtdiEepromNotProgrammedException()
        {
        }

        public FtdiEepromNotProgrammedException(string message) : base(message)
        {
        }

        public FtdiEepromNotProgrammedException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiEepromNotProgrammedException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }
    }
}
