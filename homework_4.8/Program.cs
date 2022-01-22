using System;

namespace homework_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1---------------------------------
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];

            Random r = new Random();
            int count = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(10);
                    count += arr2d[i, j];
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов матрицы равна: {count}");
            Console.WriteLine();

            //Задание №2--------------------------------------------------------

            Console.WriteLine("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] collection = new int[n];
            
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i + 1}");
                collection[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{collection[j]} ");
                if (collection[j] < min)
                {
                    min = collection[j];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальным числом является {min}");
            Console.WriteLine();

            // Задание №3---------------------------------------------------------
            int tries = 0;

            Console.WriteLine("Введите максимальное целое число для диапозона: ");
            int maxNum = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int guessedNumber = rand.Next(0, maxNum);

            while (true)
            {
                Console.Write("\nВведите число: ");
                tries++;
                var userInput = Console.ReadLine();

                if (userInput == "")
                {
                    Console.WriteLine($"Загаданым числом было {guessedNumber}");
                    break;
                }

                var userNumber = int.Parse(userInput);
                if (userNumber < guessedNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще");
                }
                else if (userNumber > guessedNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! ВЫ УГАДАЛИ с {tries} попыток.");
                    break;

                }
            }
            Console.ReadKey();
        }
    }
}
