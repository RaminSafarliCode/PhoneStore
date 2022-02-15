using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.PhoneStore
{
    internal class Phone
    {
        public int id;
        public string producer;
        public string name;
        public int year;
        public string operatingSystem;
        public string operatingSystemVersion;
        public double displaySize;
        public double mainCamera;
        public double frontCamera;
        public int video;
        public string material;
        public int core;
        public int sim;
        public int memory;
        public int ram;
        public string screenResolution;
        public string threeg;
        public string fourg;
        public string nfc;
        public string chipset;
        public string network;
        public int battery;
        public double price;

        static int counter = 0;

        public Phone()
        {
            counter++;
            id = counter;
        }

        public override string ToString()
        {
            return $"Product: {id}\n" +
                $"Producer: {producer}\n" +
                $"Model: {name}\n" +
                $"Release year: {year}\n" +
                $"Operating system: {operatingSystem}\n" +
                $"Operating system version: {operatingSystemVersion}\n" +
                $"Display size: {displaySize} inches \n" +
                $"Main camera: {mainCamera} MP\n" +
                $"Front camera: {frontCamera} MP\n" +
                $"Case material: {material}\n" +
                $"Number of cores: {core}\n" +
                $"Numbe of SIM holders: {sim}\n" +
                $"Memory: {memory} GB \n" +
                $"RAM: {ram} GB\n" +
                $"Screen resolution: {screenResolution} pixels\n" +
                $"3g: {threeg}\n" +
                $"4g: {fourg}\n" +
                $"NFC: {nfc}\n" +
                $"Chipset: {chipset}\n" +
                $"Network type: {network}\n" +
                $"Battery: {id}\n" +
                $"Price: {price} AZN \n";

        }
    }
}
