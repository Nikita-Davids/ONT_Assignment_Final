using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleCapabilities;

namespace VehicleAssembly.VehicleTypes
{
    public class LightVehicle : IVehicle
    {
        Carrier carrierInfo = new Carrier();
        Engine engineInfo = new Engine();
        Towing towingInfo = new Towing();

        public double Price { get; set; }

        public void GetDescription()
        {
            Console.WriteLine(
                $"Light vehicle carrier info: {carrierInfo.FivePeopleAndLuggage}\n"
                    + $"Light vehicle engine info: {engineInfo.Medium}\n"
                    + $"Light vehicle towing info: {towingInfo.CanTow}"
            );
        }
    }
}
