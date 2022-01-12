using System;

namespace HomeWork_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.WriteLine("\n------------------------------");

            // Задание №2----------------------------------------------

            Console.WriteLine("Привет. Сколько у вас карт на руках?: ");
            int countCards = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= countCards; i++)
            {
                Console.WriteLine("Введите номинал карты: ");
                String cardNominal = Console.ReadLine();
                switch (cardNominal)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Неправильно введенный номинал карты.");
                        break;
                }
            }
            Console.WriteLine($"Общее значение всех карт является {sum}");
            Console.WriteLine("\n------------------------------");

            //Задание №3----------------------------------------------------------
        }
    }
}
