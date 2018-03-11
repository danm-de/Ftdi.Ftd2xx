namespace Ftdi.Ftd2xx.Interop
{
    /// <summary>
    /// Flags for FT_OpenEx
    /// </summary>
    internal enum FT_OPENEX : uint
    {
        FT_OPEN_BY_SERIAL_NUMBER = 0x00000001,
        FT_OPEN_BY_DESCRIPTION = 0x00000002,
        FT_OPEN_BY_LOCATION = 0x00000004,
    }
}
