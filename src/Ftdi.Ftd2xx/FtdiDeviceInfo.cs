using System;

namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// Type that holds device information for GetDeviceInformation method.
    /// </summary>
    public class FtdiDeviceInfo
    {
        /// <summary>
        /// Indicates device state.  Can be any combination of the following: FT_FLAGS_OPENED, FT_FLAGS_HISPEED
        /// </summary>
        public DeviceState Flags { get; }

        /// <summary>
        /// Indicates the device type.  Can be one of the following: FT_DEVICE_232R, FT_DEVICE_2232C, FT_DEVICE_BM, FT_DEVICE_AM, FT_DEVICE_100AX or FT_DEVICE_UNKNOWN
        /// </summary>
        public ChipType Type  { get; }

        /// <summary>
        /// The Vendor ID and Product ID of the device
        /// </summary>
        public uint Id  { get; }

        /// <summary>
        /// Vendor ID of the device
        /// </summary>
        public ushort VendorId => (ushort) ((Id & 0xFFFF0000) >> 16);

        /// <summary>
        /// Product ID of the device
        /// </summary>
        public ushort ProductId => (ushort) (Id & 0x0000FFFF);

        /// <summary>
        /// The physical location identifier of the device
        /// </summary>
        public uint LocationId { get; }

        /// <summary>
        /// The device serial number
        /// </summary>
        public string SerialNumber { get; }

        /// <summary>
        /// The device description
        /// </summary>
        public string Description { get; }

        
        /// <summary>
        /// The device handle.  This value is not used externally and is provided for information only.
        /// If the device is not open, this value is 0.
        /// </summary>
        public IntPtr Handle { get; }

        public FtdiDeviceInfo(DeviceState flags, ChipType type, uint id, uint locationId, IntPtr handle, string serialNumber, string description)
        {
            Flags = flags;
            Type = type;
            Id = id;
            LocationId = locationId;
            Handle = handle;
            SerialNumber = serialNumber;
            Description = description;
        }
    }
}
