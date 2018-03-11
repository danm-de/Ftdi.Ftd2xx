namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// Permitted stop bits for FTDI devices
    /// </summary>
    public class FT_STOP_BITS
    {
        /// <summary>
        /// 1 stop bit
        /// </summary>
        public const byte FT_STOP_BITS_1 = 0x00;
        /// <summary>
        /// 2 stop bits
        /// </summary>
        public const byte FT_STOP_BITS_2 = 0x02;
    }
}