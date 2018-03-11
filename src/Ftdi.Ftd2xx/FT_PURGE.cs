namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// Purge buffer constant definitions
    /// </summary>
    public class FT_PURGE
    {
        /// <summary>
        /// Purge Rx buffer
        /// </summary>
        public const byte FT_PURGE_RX = 0x01;
        /// <summary>
        /// Purge Tx buffer
        /// </summary>
        public const byte FT_PURGE_TX = 0x02;
    }
}