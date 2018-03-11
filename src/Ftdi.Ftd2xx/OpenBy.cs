namespace Ftdi.Ftd2xx
{
    /// <summary>
    /// Flags for FT_OpenEx
    /// </summary>
    internal enum OpenBy : uint
    {
        SerialNumber = 0x00000001,
        Description = 0x00000002,
        Location = 0x00000004,
    }
}
