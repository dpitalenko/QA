using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Triangle
{
    public class Triangle
    {
        public int a;
        public int b;
        public int c;

        public bool inequality(int a, int b, int c)
        {
            return ((a + b > c) & (a + c > b) & (b + c > a));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Введите стороны треугольника!\na = ");
            triangle.a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            triangle.b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            triangle.c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(triangle.inequality(triangle.a, triangle.b, triangle.c));
        }
    }
}
