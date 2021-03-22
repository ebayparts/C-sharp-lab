using System;
using System.Collections.Generic;
using C_Sharp_LAB_WorkInheritance__Shape_;

namespace Test_Access
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new();
            Circle circle = new(5);
            Rectangle rectangle = new(2, 4);
            Circle circle1 = new(3);
            Rectangle rectangle1 = new(3, 5);
            shapes.Add(circle);
            shapes.Add(circle1);
            shapes.Add(rectangle);
            shapes.Add(rectangle1);
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Print();
            }
            shapes.Sort((x, y) => x.Area.CompareTo(y.Area));

            Console.WriteLine("After sorting by area:");
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Print();
            }
            List<Shape> circles = shapes.FindAll((shapes) => shapes.GetType().Name == "Circle");

            Console.WriteLine("\nGetting circles from shapes:");
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].Print();
            }
            Parallelepiped paralelepiped = new(4, 5, 3);
            Parallelepiped paralelepiped1 = new(2, 3, 2);
            Square square = new(5);
            Square square1 = new(6);
            Square square2 = new(7);

            shapes.Add(paralelepiped);
            shapes.Add(paralelepiped1);
            shapes.Add(square);
            shapes.Add(square1);
            shapes.Add(square2);

            List<Shape> rectangles = shapes.FindAll((shapes) => shapes.GetType().Name == "Rectangle");
            List<Shape> squares = shapes.FindAll((shapes) => shapes.GetType().Name == "Square");
            List<Shape> parallelepipeds = shapes.FindAll((shapes) => shapes.GetType().Name == "Parallelepiped");

            Console.WriteLine("\nAll rectangles:");
            for (int i = 0; i < rectangles.Count; i++)
            {
                rectangles[i].Print();
            }

            Console.WriteLine("\nAll squares:");
            for (int i = 0; i < squares.Count; i++)
            {
                squares[i].Print();
            }

            Console.WriteLine("\nAll parallelepipeds:");
            for (int i = 0; i < parallelepipeds.Count; i++)
            {
                parallelepipeds[i].Print();
            }
        }
    }
}