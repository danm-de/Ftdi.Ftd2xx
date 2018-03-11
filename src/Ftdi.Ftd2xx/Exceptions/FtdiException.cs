using System;
using System.Runtime.Serialization;

namespace Ftdi.Ftd2xx.Exceptions
{
    /// <summary>
    /// Exceptions thrown by errors within the FTDI class.
    /// </summary>
    [Serializable]
    public class FtdiException : Exception
    {
        /// <summary>
        /// Creates an exception
        /// </summary>								   
        public FtdiException()
        {
        }

        /// <summary>
        /// Creates an exception
        /// </summary>
        /// <param name="message">Error message</param>
        public FtdiException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates an exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="inner">Inner exception</param>
        public FtdiException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Creates an exception
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FtdiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
