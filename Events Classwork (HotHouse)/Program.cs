using System;

namespace Events_Classwork__HotHouse_
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater { };
            Cooler cooler = new Cooler { };
            Well well = new Well { };
            HotHouse hotHouse = new HotHouse { };
            hotHouse.TooCold += heater.Warm;
            hotHouse.TooHot += cooler.Cool;
            hotHouse.Well += well.Ok;
            hotHouse.Temperature = 24;
            Console.WriteLine("--------------------Nature influence imitation:------------------");
            for (int i = 0; i < 30; i++)
            {
                //Console.ReadKey(); // <- I thought it will be faster to use "Sleep" method than press any button 30 times:
                System.Threading.Thread.Sleep(200);
                Random random = new Random();
                hotHouse.Temperature += random.Next(-5, 5);
            }
        }
    }
}