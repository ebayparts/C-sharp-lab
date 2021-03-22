using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_LAB_WorkInheritance__Shape_
{
    public class Circle : Shape
    {
        uint radius = 0;
        public override double Area { get => Math.PI * Radius * Radius; }
        public Circle(uint radius)
        {
            Radius = radius;
        }
        public uint Radius
        {
            get => radius;
            set => radius = value;
        }
        public override void Print()
        {
            Console.WriteLine($"Shape name: {this.GetType().Name}\t\tArea: {Math.Round(Area, 2)}");
        }
    }
}