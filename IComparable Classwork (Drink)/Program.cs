using System;
using System.Collections.Generic;

namespace IComparable_Classwork__Drink_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drink> drinks = new List<Drink>
            {
            new Drink("Morshinka", (DrinkType)1, "Morshin", 30, 10),
            new Drink("Pepsi", (DrinkType)0, "Pepsi-Cola", 50, 30),
            new Drink("Sprite", (DrinkType)0, "Coca-Cola", 40, 35),

            new Drink("Gorilka", (DrinkType)1, "Gorilka factory", 150, 80)
        };
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }
            drinks.Sort();
            Console.WriteLine("After sorting:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------Using Compare Object)--------------");
            CompareByPriceAsc a = new CompareByPriceAsc();
            drinks.Sort(a.Compare);
            Console.WriteLine("After sorting ByPriceAsc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            CompareByKkalDesc b = new CompareByKkalDesc();
            drinks.Sort(b.Compare);
            Console.WriteLine("After sorting ByKkalDesc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            CompareByManAsc c = new CompareByManAsc();
            drinks.Sort(c.Compare);
            Console.WriteLine("After sorting ByManAsc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------Using Compare Drink)--------------");
            drinks.Sort(new CompareByPriceDesc());
            Console.WriteLine("After sorting ByPriceDesc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            drinks.Sort(new CompareByKkalAsc());
            Console.WriteLine("After sorting ByKkalAsc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            drinks.Sort(new CompareByManAsc());
            Console.WriteLine("After sorting ByManAsc:");
            foreach (var item in drinks)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"-----------------Checking IEquatable interface implementation: ------------");
            drinks.Add(new Drink("Fanta", (DrinkType)1, "Coca-Cola", 15,22));
            if (drinks[0].Manufacturer.Equals(drinks[4].Manufacturer))
                Console.WriteLine($"Manufacturer \"{drinks[0].Manufacturer}\" is EQUAL to \"{drinks[4].Manufacturer}\"");
            else
                Console.WriteLine($"Manufacturer \"{drinks[0].Manufacturer}\" is NOT EQUAL to \"{drinks[4].Manufacturer}\"");


        }

    }
}
