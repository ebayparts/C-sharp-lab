using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_LAB_WorkInheritance__Shape_;

namespace Test_Access
{
    class Square : Shape
    {
        uint side = 0;
        public uint Side
        {
            get => side;
            set => side = value;
        }
        public override double Area => side * side;
        public Square(uint side)
        {
            Side = side;
        }
        public override void Print()
        {
            Console.WriteLine($"Shape name: {this.GetType().Name}\t\tArea: {Area}");
        }
    }
}