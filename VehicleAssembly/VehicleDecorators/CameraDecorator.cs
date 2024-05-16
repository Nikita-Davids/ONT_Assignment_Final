using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleTypes;

namespace VehicleAssembly.VehicleDecorators
{
    public class CameraDecorator : IVehicleDecorator
    {
        private readonly IVehicle _vehicle;
        private double _cameraCost;

        public double Price
        {
            get { return _vehicle.Price + _cameraCost; }
        }

        public CameraDecorator(IVehicle vehicle, IVehicle initialType)
        {
            _vehicle = vehicle;

            if (CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.Motorbike)
            {
                _cameraCost = 200;
            }
            else if (
                CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.LightVehicle
            )
            {
                _cameraCost = 400;
            }
            else if (
                CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.HeavyVehicle
            )
            {
                _cameraCost = 600;
            }
        }

        public void GetDescription()
        {
            _vehicle.GetDescription();
            Console.WriteLine("");
            Console.WriteLine("Adding Custom Spec As Requested...");
            Console.WriteLine("Reverse Camera Shall Be Added");
            Console.WriteLine($"Your Total: R{Price}");
        }
    }
}
