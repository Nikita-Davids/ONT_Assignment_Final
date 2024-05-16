using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssembly.VehicleCapabilities
{
    public class Carrier
    {
        public string GoodsAndDriver { get; } = "Goods and Driver";
        public string TwoPeopleAndBag { get; } = "2 People Max and Bag";
        public string FivePeopleAndLuggage { get; } = "5 People Max and Few Luggage";
        public string TwentyPeople { get; } = "20 People Max";
        public string SixtyfivePeople { get; } = "65 People Max";
    }
}
