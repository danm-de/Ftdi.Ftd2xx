using System;
using Ftdi.Ftd2xx;

namespace ShowDeviceList
{
    class Program
    {
        static void Main(string[] args)
        {
            var devices = new FtdiDevices();
            var infos = devices.GetAllInfo();

            foreach(var info in infos)
            {
                Console.WriteLine("vendor id: {0:X4}, product id: {1:X4}, location id: {2}, type: {3}, serial number: {4}, flags: {5},\n\tdescription: {6}",
                    info.VendorId,
                    info.ProductId,
                    info.LocationId,
                    info.Type,
                    info.SerialNumber,
                    info.Flags,
                    info.Description);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
