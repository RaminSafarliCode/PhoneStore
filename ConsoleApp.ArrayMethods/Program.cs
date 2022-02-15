
using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            double eded = r.Next() + r.NextDouble();

            Console.WriteLine(eded);

            //byte[] lotoNumbers = new byte[5];

            //r.NextBytes(lotoNumbers);

            //foreach (byte item in lotoNumbers)
            //{
            //    Console.Write($"{item} ");
            //}



































            //Console.WriteLine("Eded daxil etmek ucun <Enter>, eks halda press eny key...");

            //int[] ededler = new int[0];
            //int eded;
            //int len;

            //var kliklenenDuyme = Console.ReadKey();

            //while (kliklenenDuyme.Key == ConsoleKey.Enter)
            //{
            //    eded = Monitor.ReadInteger($"{ededler.Length + 1} eded: ");
            //    len = ededler.Length;

            //    Array.Resize(ref ededler, len+1);
            //    ededler[len] = eded;

            //    Console.WriteLine("Eded daxil etmek ucun <Enter>, eks halda press eny key...");
            //    kliklenenDuyme = Console.ReadKey();

            //}            

            //Console.CursorLeft = 0;

            //Console.WriteLine("#########################\nEdedler: ");
            //foreach (var item in ededler)
            //{
            //    Console.WriteLine($"{item} ");
            //}

        }
    }
}