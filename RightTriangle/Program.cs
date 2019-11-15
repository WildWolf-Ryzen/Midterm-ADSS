using System;

namespace RightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter dimensions to check if a right triangle can be constructed.");
            Console.WriteLine("Enter a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c.");
            c = Convert.ToInt32(Console.ReadLine());

            double sqa = a * a;
            double sqb = b * b;
            double sqc = c * c;
            double bc = b + c;
            double perimetar = a + b + c;


            if (a < bc)
            {
                if (sqc == sqa + sqb)
                {
                    Console.WriteLine("The triangle is a right triangle and its perimeter is: " + perimetar);
                }
            }
            else
                Console.WriteLine("Its not a right triangle.");
        }
    }
}
