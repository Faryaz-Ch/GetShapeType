using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical_2_Q_2
{
    /// <summary>
    /// C# program that count rectangular objects with overlapping colors and premeters between two arrays.
    /// Author: Faryaz
    /// </summary>

    class Shape
    {
        public string Colour { get; set; }
        public Shape(string clor)
        {
            Colour = clor;
        }
        public virtual string GetShapeType()
        {
            return "GeneralShape";

        }

    }
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(string clr, double ht, double wd) : base(clr)

        {
            Height = ht;
            Width = wd;
        }

        public override string GetShapeType()
        {
            return "GeneralShape";
        }
        public double GetPerimeter()
        {
            double perimeter;
            perimeter = 2 * (Width + Height);

            return perimeter;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangleArray1 = {
                             new Rectangle("white", 4, 3),
                             new Rectangle("red", 9, 5),
                             new Rectangle("purple", 3, 6),
                             new Rectangle("orange", 15, 10),
                             new Rectangle("black", 4, 14),

                             };
            Rectangle[] rectangleArray2 = {
                             new Rectangle("pink", 3, 4),
                             new Rectangle("red", 10, 2),
                             new Rectangle("white", 8, 5),
                             new Rectangle("blue", 14, 4),
                             new Rectangle("bindle", 10, 15),
                             };
            int count = 0;
            int count1 = 0;
            foreach (Rectangle r1 in rectangleArray1)
            {

                foreach (Rectangle r2 in rectangleArray2)
                {
                    if (r1.Colour == r2.Colour)
                    {

                        count++;

                    }
                    if (r1.GetPerimeter() == r2.GetPerimeter())
                    {
                        count1++;
                    }

                }
            }
            WriteLine($"There are {count} rectangle objects with overlapping colours between two arrays");

            WriteLine($"There are {count1} rectangle objects with overlappping perimeters between the two arrays");

        }
    }
}