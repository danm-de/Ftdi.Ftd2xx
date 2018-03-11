namespace Ftdi.Ftd2xx.Eeprom
{
    /// <summary>
    /// Common EEPROM elements for all devices.  Inherited to specific device type EEPROMs.
    /// </summary>
    public class FT_EEPROM_DATA
    {
        //private const UInt32 Signature1     = 0x00000000;
        //private const UInt32 Signature2     = 0xFFFFFFFF;
        //private const UInt32 Version        = 0x00000002;
        /// <summary>
        /// Vendor ID as supplied by the USB Implementers Forum
        /// </summary>
        public ushort VendorID = 0x0403;

        /// <summary>
        /// Product ID
        /// </summary>
        public ushort ProductID = 0x6001;

        /// <summary>
        /// Manufacturer name string
        /// </summary>
        public string Manufacturer = "FTDI";

        /// <summary>
        /// Manufacturer name abbreviation to be used as a prefix for automatically generated serial numbers
        /// </summary>
        public string ManufacturerID = "FT";

        /// <summary>
        /// Device description string
        /// </summary>
        public string Description = "USB-Serial Converter";

        /// <summary>
        /// Device serial number string
        /// </summary>
        public string SerialNumber = "";

        /// <summary>
        /// Maximum power the device needs
        /// </summary>
        public ushort MaxPower = 0x0090;

        //private bool PnP                    = true;
        /// <summary>
        /// Indicates if the device has its own power supply (self-powered) or gets power from the USB port (bus-powered)
        /// </summary>
        public bool SelfPowered = false;

        /// <summary>
        /// Determines if the device can wake the host PC from suspend by toggling the RI line
        /// </summary>
        public bool RemoteWakeup = false;
    }
}
