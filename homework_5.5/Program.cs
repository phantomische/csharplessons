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

                
        public static string ReverseWords(string word)
        {
            string[] array = SplitWords(word);
            string result = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] + " ";
            }
            return result;
        }

        public static string[] SplitWords(string inputPhrase)
        {
            string[] newWords = inputPhrase.Split(' ');
            return newWords;
        }

        static void Main(string[] args)
        {
            string result = ReverseWords("I would like to become a developer");
            Console.WriteLine(result);
            
            
        }
    }
}
