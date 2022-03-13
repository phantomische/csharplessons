using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._8
{
    class EmployeeRepository
    {
        
        public EmployeeRepository()
        {

        }
        
        
        public void ReadData()
        {
            using (StreamReader sr = new StreamReader(@"E:\employees.csv", Encoding.Unicode))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.WriteLine($"Нажмите Enter для продолжения\n");

            Console.ReadKey(); Console.Clear();
        }

        public void WriteData()
        {
            string path = @"E:\employees.csv";
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode))
            {
                char key = 'y';

                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите ID сотрудника: ");
                    note += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToString();
                    Console.WriteLine($"Дата и время добавления записи: {now}");
                    note += $"{now}\t";

                    Console.Write("Ф.И.О: ");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Возраст: ");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Рост: ");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Дата рождения: ");
                    note += $"{Console.ReadLine()}\t";

                    Console.Write("Место рождения: ");
                    note += $"{Console.ReadLine()}\t";
                    sw.WriteLine(note);
                    Console.Write("Продолжить y/n"); key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'y');
            }
            Console.WriteLine();
            Console.WriteLine($"Файл {path} успешно создан. Нажмите Enter для продолжения\n");
            Console.ReadLine();
        }


    }
}
