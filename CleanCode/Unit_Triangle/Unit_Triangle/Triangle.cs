using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Triangle
{
    public class Triangle
    {
        public int SideA;
        public int SideB;
        public int SideC;

        public bool IsTrianglePossible(int sideA, int sideB, int sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Введите стороны треугольника!\na = ");
            triangle.SideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            triangle.SideB = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            triangle.SideC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(triangle.IsTrianglePossible(triangle.SideA, triangle.SideB, triangle.SideC));
        }
    }
}
