using System;
using Ftdi.Ftd2xx.Exceptions;

namespace Ftdi.Ftd2xx.Interop
{
    internal static class FT_STATUS_Ext
    {
        /// <summary>
        /// Method to check ftStatus and ftErrorCondition values for error conditions and throw exceptions accordingly.
        /// </summary>
        public static void ThrowOnError(this FT_STATUS ftStatus, FT_ERROR ftErrorCondition)
        {
            ftStatus.ThrowOnError();
            ftErrorCondition.ThrowOnError();
        }

        public static void ThrowOnError(this FT_ERROR ftErrorCondition)
        {
            // Check for other error conditions not handled by FTD2XX DLL
            switch (ftErrorCondition)
            {
                case FT_ERROR.FT_NO_ERROR:
                    return;
                case FT_ERROR.FT_INCORRECT_DEVICE:
                    throw new FtdiIncorrectDeviceException(
                        "The current device type does not match the EEPROM structure.");
                case FT_ERROR.FT_INVALID_BITMODE:
                    throw new FtdiInvalidBitmodeException(
                        "The requested bit mode is not valid for the current device.");
                case FT_ERROR.FT_BUFFER_SIZE:
                    throw new FtdiBufferSizeException("The supplied buffer is not big enough.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(ftErrorCondition), ftErrorCondition, null);
            }
        }

        public static void ThrowOnError(this FT_STATUS ftStatus)
        {
            // Check FT_STATUS values returned from FTD2XX DLL calls
            switch (ftStatus)
            {
                case FT_STATUS.FT_OK: return;
                case FT_STATUS.FT_DEVICE_NOT_FOUND:
                    throw new FtdiDeviceNotFoundException("FTDI device not found.");
                case FT_STATUS.FT_DEVICE_NOT_OPENED:
                    throw new FtdiDeviceNotOpenedException("FTDI device not opened.");
                case FT_STATUS.FT_DEVICE_NOT_OPENED_FOR_ERASE:
                    throw new FtdiDeviceNotOpenedForEraseException("FTDI device not opened for erase.");
                case FT_STATUS.FT_DEVICE_NOT_OPENED_FOR_WRITE:
                    throw new FtdiDeviceNotOpenedForWriteException("FTDI device not opened for write.");
                case FT_STATUS.FT_EEPROM_ERASE_FAILED:
                    throw new FtdiEepromEraseFailedException("Failed to erase FTDI device EEPROM.");
                case FT_STATUS.FT_EEPROM_NOT_PRESENT:
                    throw new FtdiEepromNotPresentException("No EEPROM fitted to FTDI device.");
                case FT_STATUS.FT_EEPROM_NOT_PROGRAMMED:
                    throw new FtdiEepromNotProgrammedException("FTDI device EEPROM not programmed.");
                case FT_STATUS.FT_EEPROM_READ_FAILED:
                    throw new FtdiEepromReadFailedException("Failed to read FTDI device EEPROM.");
                case FT_STATUS.FT_EEPROM_WRITE_FAILED:
                    throw new FtdiEepromWriteFailedException("Failed to write FTDI device EEPROM.");
                case FT_STATUS.FT_FAILED_TO_WRITE_DEVICE:
                    throw new FtdiFailedToWriteDeviceException("Failed to write to FTDI device.");
                case FT_STATUS.FT_INSUFFICIENT_RESOURCES:
                    throw new FtdiInsufficientResourcesException("Insufficient resources.");
                case FT_STATUS.FT_INVALID_ARGS:
                    throw new FtdiInvalidArgsException("Invalid arguments for FTD2XX function call.");
                case FT_STATUS.FT_INVALID_BAUD_RATE:
                    throw new FtdiInvalidBaudRateException("Invalid Baud rate for FTDI device.");
                case FT_STATUS.FT_INVALID_HANDLE:
                    throw new FtdiInvalidHandleException("Invalid handle for FTDI device.");
                case FT_STATUS.FT_INVALID_PARAMETER:
                    throw new FtdiInvalidParameterException("Invalid parameter for FTD2XX function call.");
                case FT_STATUS.FT_IO_ERROR:
                    throw new FtdiIoErrorException("FTDI device IO error.");
                case FT_STATUS.FT_OTHER_ERROR:
                    throw new FtdiOtherErrorException(
                        "An unexpected error has occurred when trying to communicate with the FTDI device.");
                default:
                    throw new FtdiException(string.Format("Error: {0}", ftStatus));
            }
        }
    }
}
