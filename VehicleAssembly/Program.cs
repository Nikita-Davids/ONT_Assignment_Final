using System.Linq.Expressions;
using VehicleAssembly;
using VehicleAssembly.VehicleCapabilities;
using VehicleAssembly.VehicleDecorators;
using VehicleAssembly.VehicleTypes;
using static VehicleAssembly.Observer.WiFiProvider;

Console.WriteLine("Choose your vehicle type: ");
Console.WriteLine("1) Motorbike");
Console.WriteLine("2) Light Vehicle");
Console.WriteLine("3) Heavy Vehicle");

var prompt = Console.ReadLine();

switch (prompt)
{
    case "1":

        IVehicle motorBike = new MotorBike();
        motorBike.GetDescription();
        Console.WriteLine("Do you want to add a sound system to your vehicle? Y / N ");
        prompt = Console.ReadLine();
        if (prompt == "Y")
        {
            Console.Clear();
            IVehicle soundVehicle = new SoundSystemDecorator(motorBike, motorBike);
            soundVehicle.GetDescription();

            Console.WriteLine("Do you want to add wifi to your vehicle? Y / N ");
            prompt = Console.ReadLine();

            if (prompt == "Y")
            {
                Console.Clear();
                IVehicle wifiVehicle = new WifiDecorator(soundVehicle, motorBike);
                WiFiInstallationCenter installationCenter = new WiFiInstallationCenter();

                VehicleType owner1 = new VehicleType("Vehicle");

                installationCenter.Attach(owner1);

                // Simulate WiFi installation
                wifiVehicle.GetDescription();
                installationCenter.InstallWiFi("WiFi");

                Console.ReadLine();
                wifiVehicle.GetDescription();

                Console.WriteLine("Do you want to add a camera to your vehicle? Y / N ");
                prompt = Console.ReadLine();

                if (prompt == "Y")
                {
                    Console.Clear();
                    IVehicle cameraVehicle = new CameraDecorator(wifiVehicle, motorBike);
                    cameraVehicle.GetDescription();
                }
            }
        }

        break;
    case "2":
        IVehicle lightVehicle = new LightVehicle();
        lightVehicle.GetDescription();
        Console.WriteLine("Do you want to add a sound system to your vehicle? Y / N ");
        prompt = Console.ReadLine();
        if (prompt == "Y")
        {
            Console.Clear();
            IVehicle soundVehicle = new SoundSystemDecorator(lightVehicle, lightVehicle);

            soundVehicle.GetDescription();

            Console.WriteLine("Do you want to add wifi to your vehicle? Y / N ");
            prompt = Console.ReadLine();

            if (prompt == "Y")
            {
                Console.Clear();
                IVehicle wifiVehicle = new WifiDecorator(soundVehicle, lightVehicle);
                WiFiInstallationCenter installationCenter = new WiFiInstallationCenter();

                VehicleType owner1 = new VehicleType("Vehicle");

                installationCenter.Attach(owner1);

                // Simulate WiFi installation
                wifiVehicle.GetDescription();
                installationCenter.InstallWiFi("WiFi");

                Console.ReadLine();
              
                wifiVehicle.GetDescription();

                Console.WriteLine("Do you want to add a camera to your vehicle? Y / N ");
                prompt = Console.ReadLine();

                if (prompt == "Y")
                {
                    Console.Clear();
                    IVehicle cameraVehicle = new CameraDecorator(wifiVehicle, lightVehicle);
                    cameraVehicle.GetDescription();
                }
            }
        }
        break;
    case "3":

        IVehicle heavyVehicle = new HeavyVehicle();
        heavyVehicle.GetDescription();
        Console.WriteLine("Do you want to add a sound system to your vehicle? Y / N ");
        prompt = Console.ReadLine();
        if (prompt == "Y")
        {
            Console.Clear();
            IVehicle soundVehicle = new SoundSystemDecorator(heavyVehicle, heavyVehicle);
            soundVehicle.GetDescription();

            Console.WriteLine("Do you want to add wifi to your vehicle? Y / N ");
            prompt = Console.ReadLine();

            if (prompt == "Y")
            {
                Console.Clear();
                IVehicle wifiVehicle = new WifiDecorator(soundVehicle, heavyVehicle);


                WiFiInstallationCenter installationCenter = new WiFiInstallationCenter();

                VehicleType owner1 = new VehicleType("Vehicle");

                installationCenter.Attach(owner1);
                wifiVehicle.GetDescription();
                installationCenter.InstallWiFi("WiFi");

                Console.ReadLine();
                wifiVehicle.GetDescription();


                // Prompt to add camera
                Console.WriteLine("Do you want to add a camera to your vehicle? Y / N ");
                prompt = Console.ReadLine();

                if (prompt == "Y")
                {
                    Console.Clear();
                    IVehicle cameraVehicle = new CameraDecorator(wifiVehicle, heavyVehicle);
                    cameraVehicle.GetDescription();
                }
            }
        }
        break;
    default:
        Console.WriteLine("Choose between 1 & 3");
        break;
}

Console.ReadLine();

// ObserverBase
public interface IVehicleType
{
    void ReceiveWiFiInstallationNotification(string wifiModel);
}

// SubjectBase
public abstract class WiFiProvider
{
    // Holds the collection of the observers
    private List<IVehicleType> VehicleTypes = new List<IVehicleType>();

    public void Attach(IVehicleType vehicleType)
    {
        VehicleTypes.Add(vehicleType);
    }

    public void Detach(IVehicleType vehicleTypes)
    {
        VehicleTypes.Remove(vehicleTypes);
    }

    public void NotifyCarOwners(string wifiModel)
    {
        foreach (var vehicle in VehicleTypes)
        {
            vehicle.ReceiveWiFiInstallationNotification(wifiModel);
        }
    }

    // ConcreteSubject class
    public class WiFiInstallationCenter : WiFiProvider
    {
        public void InstallWiFi(string wifiModel)
        {
            Console.WriteLine($"Installing {wifiModel}");
            NotifyCarOwners(wifiModel);
        }
    }

    // ConcreteObserver class
    public class VehicleType : IVehicleType
    {
        private string vehicleName;

        public VehicleType(string vehicleName)
        {
            this.vehicleName = vehicleName;
        }
        public void ReceiveWiFiInstallationNotification(string wifiModel)
        {
            Console.WriteLine($"{vehicleName} received update notification: {wifiModel} has been installed and you will now be receiving newsletters.");
        }
    }

}

