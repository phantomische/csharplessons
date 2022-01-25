using System;

namespace homework_5._5
{
    class Program
    {
        string phrase = string.Empty;
        string[] words = new string[];
        static void StringToWords (string phrase, string[] words)
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


        static void Main(string[] args)
        {
            StringToWords();
            PrintArray();
            
        }
    }
}
