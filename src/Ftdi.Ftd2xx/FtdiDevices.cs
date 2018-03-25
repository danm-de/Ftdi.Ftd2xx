using System;
using System.Collections.Generic;
using System.Text;
using Ftdi.Ftd2xx.Extensions;
using Ftdi.Ftd2xx.Interop;

namespace Ftdi.Ftd2xx
{
    public class FtdiDevices
    {
        private static readonly object _infoSync = new object();
        private readonly IFtdiApi _api;

        public FtdiDevices()
            : this(FtdiApi.Instance)
        {
        }

        public FtdiDevices(IFtdiApi api)
        {
            _api = api;
        }

        public IReadOnlyList<FtdiDeviceInfo> GetAllInfo()
        {
            lock (_infoSync)
            {
                uint devcount = 0;
                _api.CreateDeviceInfoList(ref devcount)
                    .ThrowOnError();

                if (devcount <= 0)
                {
                    return new FtdiDeviceInfo[0];
                }

                var deviceNodes = new FtdiDeviceInfo[devcount];
                
                // buffer
                DeviceState flags = 0;
                var chipType = ChipType.Unknown;
                uint id = 0;
                uint locId = 0;
                var ftHandle = IntPtr.Zero;
                var snBuf = new byte[16];
                var descBuf = new byte[64];
                
                for (uint i = 0; i < devcount; i++)
                {
                    _api.GetDeviceInfoDetail(
                            i,
                            ref flags,
                            ref chipType,
                            ref id,
                            ref locId,
                            snBuf,
                            descBuf,
                            ref ftHandle)
                        .ThrowOnError();

                    var serialNumberLength = snBuf.IndexOf(0) ?? 0;
                    var descriptionLength = descBuf.IndexOf(0) ?? 0;
                    var serialNumber = Encoding.ASCII.GetString(snBuf, 0, serialNumberLength);
                    var description = Encoding.ASCII.GetString(descBuf, 0, descriptionLength);
                    var node = new FtdiDeviceInfo(
                        flags: flags,
                        type: chipType,
                        id: id,
                        locationId: locId,
                        handle: ftHandle,
                        serialNumber: serialNumber,
                        description: description
                    );
                    deviceNodes[i] = node;
                }

                return deviceNodes;
            }
        }
    }
}
