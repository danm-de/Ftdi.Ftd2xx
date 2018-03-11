using System;

namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// Flags that provide information on the FTDI device state
    /// </summary>
    [Flags]
    public enum DeviceState : uint
    {
        /// <summary>
        /// Indicates that the device is open
        /// </summary>
        Opened = 0x00000001,

        /// <summary>
        /// Indicates that the device is enumerated as a hi-speed USB device
        /// </summary>
        HighSpeed = 0x00000002
    }
}
