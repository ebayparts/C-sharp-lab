using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_LAB_WorkInheritance__Shape_
{
    public class Rectangle : Shape
    {
        uint height = 0;
        uint width = 0;
        public uint Height
        {
            get => height;
            set => height = value;
        }
        public uint Width
        {
            get => width;
            set => width = value;
        }
        override public double Area { get => height * width; }
        public Rectangle(uint height, uint width)
        {
            Height = height;
            Width = width;
        }
        override public void Print()
        {
            Console.WriteLine($"Shape name: {this.GetType().Name}\t\tArea: {Area}");
        }
    }
}
