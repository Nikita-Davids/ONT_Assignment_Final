using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleTypes;

namespace VehicleAssembly.VehicleDecorators
{
    public class WifiDecorator : IVehicleDecorator
    {
        private readonly IVehicle _vehicle;
        private double _wifiCost;

        public double Price
        {
            get { return _vehicle.Price + _wifiCost; }
        }

        public WifiDecorator(IVehicle vehicle, IVehicle initialType)
        {
            _vehicle = vehicle;

            if (CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.Motorbike)
            {
                _wifiCost = 750;
            }
            else if (
                CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.LightVehicle
            )
            {
                _wifiCost = 950;
            }
            else if (
                CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.HeavyVehicle
            )
            {
                _wifiCost = 1000;
            }
        }

        public void GetDescription()
        {
            _vehicle.GetDescription();
            Console.WriteLine("");
            Console.WriteLine("Adding Custom Spec As Requested...");
            Console.WriteLine("Wifi Shall Be Added");

            Console.WriteLine($"Your Total: R{Price}");
        }
    }
}
