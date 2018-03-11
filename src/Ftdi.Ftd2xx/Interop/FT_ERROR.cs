namespace Ftdi.Ftd2xx.Interop
{
    /// <summary>
    /// Error states not supported by FTD2XX DLL.
    /// </summary>
    internal enum FT_ERROR
    {
        FT_NO_ERROR = 0,
        FT_INCORRECT_DEVICE,
        FT_INVALID_BITMODE,
        FT_BUFFER_SIZE
    };
}
