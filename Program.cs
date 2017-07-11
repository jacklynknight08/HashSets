using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashSet<string> Showroom = new HashSet<string>();

            Showroom.Add("Jeep");
            Showroom.Add("Buick");
            Showroom.Add("Chevrolet");
            Showroom.Add("Ford");

            Console.WriteLine();

            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            Console.WriteLine(Showroom.Count);

            Showroom.Add("Jeep");

            Console.WriteLine();

            foreach(string cars in Showroom){
                Console.WriteLine(cars);
            }

            HashSet<string> UsedLot = new HashSet<string>();

            UsedLot.Add("Toyota");
            UsedLot.Add("Honda");

            Showroom.UnionWith(UsedLot);

            Console.WriteLine();

            foreach(string c in Showroom){
                Console.WriteLine(c);
            }

            Showroom.Remove("Toyota");

            Console.WriteLine();

            foreach(string x in Showroom){
                Console.WriteLine(x);
            }

            HashSet<string> Junkyard = new HashSet<string>();

            Junkyard.Add("Subaru");
            Junkyard.Add("Hyundai");
            Junkyard.Add("Jeep");
            Junkyard.Add("Honda");

            //Junkyard.IntersectWith(Showroom);

            Console.WriteLine();

            foreach(string junk in Junkyard){
                Console.WriteLine(junk);
            }

            Showroom.UnionWith(Junkyard);

            Console.WriteLine();

            foreach(string newCars in Showroom){
                Console.WriteLine(newCars);
            }

            Showroom.Remove("Subaru");

            Console.WriteLine();

            foreach(string newShowroom in Showroom){
                Console.WriteLine(newShowroom);
            }

        }
    }
}
