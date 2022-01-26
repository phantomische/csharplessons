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

        public static string ReverseWords(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string[] SplitWords(string inputPhrase)
        {
            string[] newWords = inputPhrase.Split(' ');
            return newWords;
        }

        static void Main(string[] args)
        {

            var newWords = SplitWords("I would like to become a developer!");

            
        }
    }
}
