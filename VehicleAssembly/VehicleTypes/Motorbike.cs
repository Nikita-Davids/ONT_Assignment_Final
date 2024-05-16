using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleCapabilities;

namespace VehicleAssembly.VehicleTypes
{
    public class MotorBike : IVehicle
    {
        Carrier carrierInfo = new Carrier();
        Engine engineInfo = new Engine();
        Towing towingInfo = new Towing();

        public double Price { get; set; }

        public void GetDescription()
        {
            Console.WriteLine(
                $"Motorbike carrier info: {carrierInfo.GoodsAndDriver} / {carrierInfo.TwoPeopleAndBag}\n"
                    + $"Motorbike engine info: {engineInfo.Small}\n"
                    + $"Motorbike towing info: {towingInfo.CannotTow}"
            );
        }
    }
}
