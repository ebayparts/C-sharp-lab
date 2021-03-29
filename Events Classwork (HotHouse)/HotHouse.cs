using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Classwork__HotHouse_
{
    delegate void HotHouseDeleg(HotHouse house);
    class HotHouse
    {
        public readonly int maxT = 23, minT = 17;
        public string Title { get; set; } = "Unsigned";
        int temperature = 15;
        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Well;
        public int Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                if (value > maxT)
                    TooHot?.Invoke(this);
                else if (value < minT)
                    TooCold?.Invoke(this);
                else
                    Well?.Invoke(this);
            }
        }
        public override string ToString()
        {
            return $"\nNew Temp: {Temperature}";
        }
    }
    class Heater
    {
        public string Name { get; set; } = "Unsigned";
        public void Warm(HotHouse h)
        {
            Console.WriteLine($"-------------Heater works. (Temp: {h.Temperature} is lower than minimum: {h.minT})");
            h.Temperature += 5;
        }
    }
    class Cooler
    {
        public void Cool(HotHouse h)
        {
            Console.WriteLine($"-------------Cooler works. (Temp: {h.Temperature} is higher than maximum: {h.maxT})");
            h.Temperature -= 5;
        }
    }
    class Well
    {
        public void Ok(HotHouse h)
        {
            Console.WriteLine($"Temperature is OK ({h.Temperature})");
        }
    }
}