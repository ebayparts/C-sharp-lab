using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp_LAB_WorkInheritance__Shape_;

namespace Test_Access
{
    public class Parallelepiped : Rectangle  // correct ONLY for Rectangular parallelepiped
    {
        uint depth = 0;
        public uint Depth
        {
            get => depth;
            set => depth = value;
        }
        override public double Area { get => 2 * (Height + Width + Depth); }
        public Parallelepiped(uint height, uint width, uint depth)
            : base(height, width)
        {
            Depth = depth;
        }
        override public void Print()
        {
            Console.WriteLine($"Shape name: {this.GetType().Name}\t\tArea: {Area}");
        }
    }
}