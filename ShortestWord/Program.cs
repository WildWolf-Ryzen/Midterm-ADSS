using System;
using System.Linq;

namespace ShortestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence.");
            string sentance;

            sentance = Console.ReadLine();

            if (sentance.Length != 0)
            {

                string[] words = sentance.Split(new[] { " " }, StringSplitOptions.None);

                string word = "";
                word = Console.ReadLine();

                var sorted = words.OrderBy(n => n.Length);
                var shortest = sorted.FirstOrDefault();

                Console.WriteLine(shortest);
            }
            else
                Console.WriteLine("Error empty string entered!");
        }
    }

}


