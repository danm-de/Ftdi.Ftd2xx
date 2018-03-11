namespace Ftdi.Ftd2xx.Interop
{
    /// <summary>
    /// FTDI device event types that can be monitored
    /// </summary>
    public class FT_EVENTS
    {
        /// <summary>
        /// Event on receive character
        /// </summary>
        public const uint FT_EVENT_RXCHAR = 0x00000001;

        /// <summary>
        /// Event on modem status change
        /// </summary>
        public const uint FT_EVENT_MODEM_STATUS = 0x00000002;

        /// <summary>
        /// Event on line status change
        /// </summary>
        public const uint FT_EVENT_LINE_STATUS = 0x00000004;
    }
}
