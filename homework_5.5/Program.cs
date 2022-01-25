using System;

namespace homework_5._5
{
    class Program
    {
        //задание №1
        static void StringToWords ()
        {
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');
        }
        
        static void PrintArray (string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }
        }

        //Задание №2


        static void Main(string[] args)
        {
            StringToWords();
            PrintArray();
            
        }
    }
}
