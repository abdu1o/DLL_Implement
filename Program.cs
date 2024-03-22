using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Implement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DLL1.Geometry.RectangleArea(2, 3));
            Console.WriteLine(DLL1.Geometry.SquareArea(2));
            Console.WriteLine(DLL1.Geometry.TriangleArea(2, 3));

            Console.WriteLine(DLL1.Text.IsPalindrome("hooh"));
            Console.WriteLine(DLL1.Text.Count("hooh"));
        }
    }
}
