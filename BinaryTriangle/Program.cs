using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTriangle
{
    class Program
    {
        public static void Main(String[] args)
        {
            int j, row = 0, input;
            Console.Write("Rows : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (row == 1)
                    {
                        Console.Write("0");
                        row = 0;
                    }
                    else if (row == 0)
                    {
                        Console.Write("1");
                        row = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}