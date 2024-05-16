using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleTypes;

namespace VehicleAssembly.VehicleDecorators
{
    public static class CompareVehicle
    {
        public enum VehicleType
        {
            None,
            Motorbike,
            LightVehicle,
            HeavyVehicle
        }

        public static VehicleType TypeOfVehicle(IVehicle vehicle)
        {
            if (vehicle is MotorBike)
            {
                return VehicleType.Motorbike;
            }
            if (vehicle is LightVehicle)
            {
                return VehicleType.LightVehicle;
            }
            if (vehicle is HeavyVehicle)
            {
                return VehicleType.HeavyVehicle;
            }
            else
            {
                return VehicleType.None;
            }
        }
    }
}
