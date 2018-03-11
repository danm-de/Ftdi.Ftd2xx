using System;

namespace Ftdi.Ftd2xx.Interop
{
    public interface IFtdiApi
    {
        FT_STATUS CreateDeviceInfoList(ref uint numdevs);

        FT_STATUS GetDeviceInfoDetail(uint index, ref DeviceState flags, ref ChipType chiptype,
            ref uint id, ref uint locid, byte[] serialnumber, byte[] description, ref IntPtr ftHandle);
    }
}
