﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Задание №1
            //List<int> numbers = new List<int>();
            //Display(numbers);
            //Console.WriteLine("\n");
            //Sort(numbers);

            // Задание №2
            string phone;
            string phoneOwner;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("1234567", "Sultan Yerbulatov");
            phoneBook.Add("1122334", "Sultan Yerbulatov");
            phoneBook.Add("9865764", "Ivan Ivanov");
            phoneBook.Add("6543210", "Petr Petrov");
            phoneBook.Add("3210123", "Sidor Sidorov");

            while (true)
            {
                Console.WriteLine("Введите номер телефона");
                phone = Console.ReadLine();
                Console.WriteLine("Введите имя владельца");
                phoneOwner = Console.ReadLine();
                phoneBook.Add(phone, phoneOwner);
                Console.WriteLine("\n");
                break;
            }
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"phone number: {item.Key}, it's owner: {item.Value}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Введите номер телефона для отображения его владельца");
            string phoneNumber = Console.ReadLine();
            string value = "";
            if (KeyValuePair)
            {

            }

        }

        //public static void Display(List<int> list)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        list.Add(random.Next(100));
        //    }
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void Sort(List<int> list)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        list.Add(random.Next(100));
        //    }
        //    var query = list.Where(x => x > 25 && x < 50).ToList();
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
