using System;

namespace homework_5._5
{
    class Program
    {
        //задание №1
        //static string[] StringToWords(string phrase)
        //{
        //    string[] words = phrase.Split(' ');
        //    return words;
        //}

        //static void PrintArray (string[] words)
        //{
        //    foreach (var word in words)
        //    {
        //        Console.WriteLine($"<{word}>");
        //    }
        //}

        //Задание №2

                
        public static void ReverseWords(string s)
        {
            string[] StringArray = SplitWords("I would like to become a developer");
            string ReversString = "";
            for (int i = StringArray.Length - 1; i >= 0; i--)
            {
                ReversString += StringArray[i] + " ";
            }
            Console.WriteLine(ReversString);
        }

        public static string[] SplitWords(string inputPhrase)
        {
            string[] newWords = inputPhrase.Split(' ');
            return newWords;
        }

        static void Main(string[] args)
        {
            ReverseWords("I would like to become a developer");
            
            
        }
    }
}
