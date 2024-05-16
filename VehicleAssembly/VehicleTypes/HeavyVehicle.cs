using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleCapabilities;

namespace VehicleAssembly.VehicleTypes
{
    public class HeavyVehicle : IVehicle
    {
        Carrier carrierInfo = new Carrier();
        Engine engineInfo = new Engine();
        Towing towingInfo = new Towing();

        public double Price { get; set; }

        public void GetDescription()
        {
            Console.WriteLine(
                $"Heavy vehicle carrier info: {carrierInfo.TwentyPeople} / {carrierInfo.SixtyfivePeople}\n"
                    + $"Heavy vehicle engine info: {engineInfo.Large} / {engineInfo.ExtraLarge}\n"
                    + $"Heavy vehicle towing info: {towingInfo.CanTow}"
            );
        }
    }
}
