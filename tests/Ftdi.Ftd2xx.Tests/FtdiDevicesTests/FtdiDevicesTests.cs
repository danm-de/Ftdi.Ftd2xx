using System;
using System.Linq;
using System.Text;
using FakeItEasy;
using FluentAssertions;
using Ftdi.Ftd2xx.Interop;
using Xunit;

namespace Ftdi.Ftd2xx.Tests.FtdiDevicesTests
{
    public abstract class FtdiDevicesSpec
    {
        protected readonly FtdiDevices Sut;
        protected readonly IFtdiApi Api = A.Fake<IFtdiApi>(opts => opts.Strict());

        protected FtdiDevicesSpec()
        {
            Sut = new FtdiDevices(Api);
        }
    }

    public class If_one_FTDI_chip_is_connected_and_the_user_wants_to_retrieve_the_device_list : FtdiDevicesSpec
    {
        public If_one_FTDI_chip_is_connected_and_the_user_wants_to_retrieve_the_device_list()
        {
            // Tell caller that one device is connected
            uint numdev = 0;
            A.CallTo(() => Api.CreateDeviceInfoList(ref numdev))
                .WithAnyArguments()
                .Returns(FT_STATUS.FT_OK)
                .AssignsOutAndRefParametersLazily(_ => new object[] {(uint) 1});

            // Prepare request for device with index 0
            var index = (uint) 0;
            var flags = default(DeviceState);
            var chiptype = default(ChipType);
            var id = default(uint);
            var locid = default(uint);
            var serialnumber = default(byte[]);
            var description = default(byte[]);
            var ftHandle = default(IntPtr);
            
            A.CallTo(() => Api.GetDeviceInfoDetail(
                    index,
                    ref flags,
                    ref chiptype,
                    ref id,
                    ref locid,
                    serialnumber,
                    description,
                    ref ftHandle))
                .WhenArgumentsMatch(call => call.Get<uint>(0) == index)
                .Invokes(call => SetAsciiString(call.GetArgument<byte[]>(5), "ABC123"))
                .Invokes(call => SetAsciiString(call.GetArgument<byte[]>(6), "MyDevice"))
                .Returns(FT_STATUS.FT_OK)
                .AssignsOutAndRefParametersLazily(_ => new object[] {
                    DeviceState.HighSpeed,
                    ChipType.FT2xxR,
                    (uint)123,
                    (uint)1234,
                    new IntPtr(789)
                });
        }

        private static void SetAsciiString(byte[] buffer, string text)
        {
            Encoding.ASCII.GetBytes(text.ToArray(), 0, text.Length, buffer, 0);
        }

        [Fact]
        public void Shall_it_return_one_device_having_all_properties_set()
        {
            Sut.GetAllInfo()
                .Should()
                .BeEquivalentTo(new FtdiDeviceInfo(
                        flags: DeviceState.HighSpeed,
                        type: ChipType.FT2xxR,
                        id: 123,
                        locationId: 1234,
                        handle: new IntPtr(789),
                        serialNumber: "ABC123",
                        description: "MyDevice"));
        }
    }

    public class If_no_chip_is_connected_and_the_user_wants_to_retrieve_the_device_list : FtdiDevicesSpec
    {
        public If_no_chip_is_connected_and_the_user_wants_to_retrieve_the_device_list()
        {
            // Tell caller that no device is connected
            uint numdev = 0;
            A.CallTo(() => Api.CreateDeviceInfoList(ref numdev))
                .WithAnyArguments()
                .Returns(FT_STATUS.FT_OK)
                .AssignsOutAndRefParametersLazily(_ => new object[] {(uint) 0});
        }
        
        [Fact]
        public void Shall_it_return_an_empty_list()
        {
            Sut.GetAllInfo().Should().BeEmpty();
        }
    }
}
