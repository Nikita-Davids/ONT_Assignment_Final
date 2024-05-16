using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAssembly.VehicleCapabilities;

namespace VehicleAssembly.VehicleTypes
{
    public interface IVehicle
    {
        public double Price { get; }
        public void GetDescription();
    }
}
