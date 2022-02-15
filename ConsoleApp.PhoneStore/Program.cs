using ClassLibrary.Helpers;
using System;

namespace ConsoleApp.PhoneStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Telephone Store v1.1";

            int value;
            l1:
            value = Monitor.ReadInteger("How many telephone will you input: ");

            Phone[] phones = new Phone[value];

            if (value <= 0)
            {
                Monitor.PrintError("Try again!");
                goto l1;
            }

            for (int i = 0; i < value; i++)
            {
                Phone phone = new Phone();

                Console.WriteLine($"Telephone number {i+1}:");
                
                phone.producer = Monitor.ReadString("Producer: ");
                phone.name = Monitor.ReadString("Model: ");
                phone.year = Monitor.ReadInteger("Release year: ");
                phone.operatingSystem = Monitor.ReadString("Operating system: ");
                phone.operatingSystemVersion = Monitor.ReadString("Operating system version: ");
                phone.displaySize = Monitor.ReadDouble("Display size: ");
                phone.mainCamera = Monitor.ReadDouble("Main camera: ");
                phone.frontCamera = Monitor.ReadInteger("Video quality: ");
                phone.material = Monitor.ReadString("Case material: ");
                phone.core = Monitor.ReadInteger("Number of cores: ");
                phone.sim = Monitor.ReadInteger("Number of SIM holders: ");
                phone.memory = Monitor.ReadInteger("Memory: ");
                phone.ram = Monitor.ReadInteger("RAM: ");
                phone.screenResolution = Monitor.ReadString("Screen resolution (**** x ****): ");
                phone.threeg = Monitor.ReadString("3g: ");
                phone.fourg = Monitor.ReadString("4g: ");
                phone.nfc = Monitor.ReadString("NFC: ");
                phone.chipset = Monitor.ReadString("Chipset: ");
                phone.network = Monitor.ReadString("Network type: ");
                phone.battery = Monitor.ReadInteger("Battery: ");
                phone.price = Monitor.ReadDouble("Price: ");

                phones[i] = phone;
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("########## List of Phones ##########");

            foreach (Phone item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------");
            }

            Console.ReadKey();
        }
    }
}
