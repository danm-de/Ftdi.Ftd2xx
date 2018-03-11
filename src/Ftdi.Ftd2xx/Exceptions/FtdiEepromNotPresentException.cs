using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    [Serializable]
    public class FtdiEepromNotPresentException : FtdiException
    {
        public FtdiEepromNotPresentException()
        {
        }

        public FtdiEepromNotPresentException(string message) : base(message)
        {
        }

        public FtdiEepromNotPresentException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FtdiEepromNotPresentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
