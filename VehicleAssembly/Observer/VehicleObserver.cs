using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static VehicleAssembly.Observer.WiFiProvider;

namespace VehicleAssembly.Observer
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                WiFiInstallationCenter installationCenter = new WiFiInstallationCenter();

                Console.WriteLine("Choose your vehicle type: ");
                Console.WriteLine("1) Motorbike");
                Console.WriteLine("2) Light Vehicle");
                Console.WriteLine("3) Heavy Vehicle");

                var prompt = Console.ReadLine();

                IVehicleType vehicleType = null;

                switch (prompt)
                {
                    case "1":
                        vehicleType = new VehicleType("Motorbike");
                        break;
                    case "2":
                        vehicleType = new VehicleType("Light Vehicle");
                        break;
                    case "3":
                        vehicleType = new VehicleType("Heavy Vehicle");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }

                installationCenter.Attach(vehicleType);

                // Simulate WiFi installation
                installationCenter.InstallWiFi("WiFi");

                installationCenter.Detach(vehicleType);

                Console.ReadLine();
            }
        }

        // ObserverBase
        public interface IVehicleType
        {
            string GetVehicleType();
        }

        // SubjectBase
        public abstract class WiFiProvider
        {
            // Holds the collection of the observers
            private List<IVehicleType> vehicleTypes = new List<IVehicleType>();

            public void Attach(IVehicleType vehicleType)
            {
                vehicleTypes.Add(vehicleType);
            }

            public void Detach(IVehicleType vehicleType)
            {
                vehicleTypes.Remove(vehicleType);
            }

            public void NotifyVehicleType(string wifiModel)
            {
                foreach (var vehicleType in vehicleTypes)
                {
                    Console.WriteLine($"Installing WiFi for {vehicleType.GetVehicleType()} , you will now be receieving newsletters");
                }
            }

            // ConcreteSubject class
            public class WiFiInstallationCenter : WiFiProvider
            {
                public void InstallWiFi(string wifiModel)
                {
                    Console.WriteLine($"Installing {wifiModel}...");
                    NotifyVehicleType(wifiModel);
                }
            }

            // ConcreteObserver class
            public class VehicleType : IVehicleType
            {
                private string type;

                public VehicleType(string type)
                {
                    this.type = type;
                }

                public string GetVehicleType()
                {
                    return type;
                }
            }
        }
    }





