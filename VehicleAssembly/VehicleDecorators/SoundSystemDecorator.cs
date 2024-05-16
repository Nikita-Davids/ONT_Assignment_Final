using VehicleAssembly.VehicleDecorators;
using VehicleAssembly.VehicleTypes;

public class SoundSystemDecorator : IVehicleDecorator
{
    private readonly IVehicle _vehicle;

    private double _soundSystemCost;

    public double Price
    {
        get { return _vehicle.Price + _soundSystemCost; }
    }

    public SoundSystemDecorator(IVehicle vehicle, IVehicle initialType)
    {
        _vehicle = vehicle;

        if (CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.Motorbike)
        {
            _soundSystemCost = 1000;
        }
        else if (
            CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.LightVehicle
        )
        {
            _soundSystemCost = 1200;
        }
        else if (
            CompareVehicle.TypeOfVehicle(initialType) == CompareVehicle.VehicleType.HeavyVehicle
        )
        {
            _soundSystemCost = 1400;
        }
    }

    public void GetDescription()
    {
        _vehicle.GetDescription();
        Console.WriteLine("");
        Console.WriteLine("Adding Custom Spec As Requested...");
        Console.WriteLine("Sound System Shall Be Installed");
        Console.WriteLine($"Your Total: R{Price}");
    }
}
