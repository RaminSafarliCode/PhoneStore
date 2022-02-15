using ClassLibrary.Helpers;
using System;

namespace ConsoleApp.GameOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int eded  = r.Next(1,101);


            int counter = 0;

            int numberFromUser = Monitor.ReadInteger("1-100 arasi eded daxil edin: ");

            do
            {
                counter++;

                if (numberFromUser > eded)
                {
                    numberFromUser = Monitor.ReadInteger("Daha kicik eded daxil edin: ");
                }
                else if (numberFromUser < eded)
                {
                    numberFromUser = Monitor.ReadInteger("Daha boyuk eded daxil edin: ");
                }
                else
                {
                    break;
                }

                if (numberFromUser == eded)
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"Cavab: {eded}; {counter}-ci cehdde tapdiniz!");
        }
    }
}
