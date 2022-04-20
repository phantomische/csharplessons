using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Display(numbers);
            Console.WriteLine("\n");
            Sort(numbers);
        }

        public static void Display(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(100));
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Sort(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(100));
            }
            var query = list.Where(x => x > 25 && x < 50).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
