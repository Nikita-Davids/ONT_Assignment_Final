using VehicleAssembly.VehicleTypes;

public interface IVehicleDecorator : IVehicle { }

/*public class LeatherSeatsDecorator : ICarDecorator
{
    private readonly ICar _car;

    public LeatherSeatsDecorator(ICar car)
    {
        _car = car;
    }

    public void Drive()
    {
        _car.Drive();
        Console.WriteLine("Leather seats installed.");
    }
}*/
