using System;
using System.Runtime.InteropServices;

namespace Ftdi.Ftd2xx.Interop
{
    internal class FtdiApi : IFtdiApi
    {
        // ReSharper disable once InconsistentNaming
        private const string FTD2XX_DLL = "FTD2XX.DLL";

        private static readonly Lazy<IFtdiApi> _instance = new Lazy<IFtdiApi>(() => new FtdiApi());
        public static IFtdiApi Instance => _instance.Value;

        [DllImport(FTD2XX_DLL, CallingConvention = CallingConvention.StdCall, EntryPoint = "FT_CreateDeviceInfoList")]
        private static extern FT_STATUS FT_CreateDeviceInfoList(ref uint numdevs);

        public FT_STATUS CreateDeviceInfoList(ref uint numdevs) => FT_CreateDeviceInfoList(ref numdevs);

        [DllImport(FTD2XX_DLL, CallingConvention = CallingConvention.StdCall, EntryPoint = "FT_GetDeviceInfoDetail")]
        private static extern FT_STATUS FT_GetDeviceInfoDetail(
            uint index,
            ref DeviceState flags,
            ref ChipType chiptype,
            ref uint id,
            ref uint locid,
            [In, Out] byte[] serialnumber,
            [In, Out] byte[] description,
            ref IntPtr ftHandle);

        public FT_STATUS GetDeviceInfoDetail(
            uint index,
            ref DeviceState flags,
            ref ChipType chiptype,
            ref uint id,
            ref uint locid,
            byte[] serialnumber,
            byte[] description,
            ref IntPtr ftHandle) => FT_GetDeviceInfoDetail(
            index,
            ref flags,
            ref chiptype,
            ref id,
            ref locid,
            serialnumber,
            description,
            ref ftHandle);
    }
}
