// ReSharper disable InconsistentNaming
namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// List of FTDI device types
    /// </summary>
    public enum ChipType
    {
        /// <summary>
        /// FT232B or FT245B device
        /// </summary>
        FT2xxBM = 0,

        /// <summary>
        /// FT8U232AM or FT8U245AM device
        /// </summary>
        FT8U2xxAM,

        /// <summary>
        /// FT8U100AX device
        /// </summary>
        FT8U100AX,

        /// <summary>
        /// Unknown device
        /// </summary>
        Unknown,

        /// <summary>
        /// FT2232 device
        /// </summary>
        FT2232,

        /// <summary>
        /// FT232R or FT245R device
        /// </summary>
        FT2xxR,

        /// <summary>
        /// FT2232H device
        /// </summary>
        FT2232H,

        /// <summary>
        /// FT4232H device
        /// </summary>
        FT4232H,

        /// <summary>
        /// FT232H device
        /// </summary>
        FT232H,

        /// <summary>
        /// FT X-Series device
        /// </summary>
        XSERIES,

        /// <summary>
        /// FT4222 hi-speed device Mode 0 - 2 interfaces
        /// </summary>
        FT4222H_0,

        /// <summary>
        /// FT4222 hi-speed device Mode 1 or 2 - 4 interfaces
        /// </summary>
        FT4222H_1_2,

        /// <summary>
        /// FT4222 hi-speed device Mode 3 - 1 interface
        /// </summary>
        FT4222H_3,

        /// <summary>
        /// OTP programmer board for the FT4222.
        /// </summary>
        FT4222PROG,
    };
}
