using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL1
{
    public static class Geometry
    {
        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double side1, double  side2)
        {
            return side1 * side2;
        }

        public static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
    }

}
