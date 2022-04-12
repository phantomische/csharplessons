using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace homework_7._8
{
    class EmployeeRepository
    {
        private object employeeRepository;

        // Список сотрудников
        private List<Employee> _employees { get; set; }

        public EmployeeRepository()
        {
            _employees = new List<Employee>();
            _employees = GetEmployeesFromCsv();
        }


        // Получаем список всех сотрудников
        public List<Employee> GetAll()
        {
            return _employees;
        }

        // Создаем сотрудника
        public void Create(Employee employee)
        {
            _employees.Add(employee);
        }

        // Просмотри сотрудника
        public void View(Employee employee)
        {
            var selectedEmployee = _employees.FirstOrDefault(e => e.ID == employee.ID);
            Console.WriteLine(selectedEmployee.ID);
        }

        
        // Редактируем сотрудника
        public void Update(Employee employee)
        {
            Console.WriteLine("Введите новую дату и время записи сотрудника");
            var NewCreatedAt = Console.ReadLine();
            employee.CreatedAt = DateTime.Parse(NewCreatedAt);

            Console.WriteLine("Введите новое Ф.И.О. сотрудника");
            var NewFullName = Console.ReadLine();
            employee.FullName = NewFullName;

            Console.WriteLine("Введите новый возраст сотрудника");
            var NewAge = Console.ReadLine();
            employee.Age = int.Parse(NewAge);

            Console.WriteLine("Введите новый рост сотрудника");
            var NewHeight = Console.ReadLine();
            employee.Height = int.Parse(NewHeight);

            Console.WriteLine("Введите новую дату рождения сотрудника");
            var NewBirthDate = Console.ReadLine();
            employee.BirthDate = NewBirthDate;

            Console.WriteLine("Введите новое место рождения сотрудника");
            var NewBirthPlace = Console.ReadLine();
            employee.PlaceOfBirth = NewBirthPlace;            
        }

        // Сохраняем изменения
        public void SaveChanges()
        {
            using (StreamWriter sw = new StreamWriter(@"E:\employees.csv", false))
            {
                foreach (var employee in _employees)
                {
                    sw.WriteLine(employee.ID + "#" + 
                                  employee.CreatedAt.ToString() + "#" +
                                  employee.FullName + "#" +
                                  employee.Age + "#" +
                                  employee.Height + "#" +
                                  employee.BirthDate + "#" +
                                  employee.PlaceOfBirth);
                }
            }
        }

        // Удаляем сотрудника
        public void Delete(Employee employee)
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.ID == employee.ID);

            _employees.Remove(oldEmployee);
        }

        // Получаем список всех сотрудников из файла csv (парсинг файла, частный метод)
        private List<Employee> GetEmployeesFromCsv()
        {
            var employees = new List<Employee>();

            using (TextFieldParser parser = new TextFieldParser(@"E:\employees.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("	");
                while (!parser.EndOfData)
                {
                    string[] props = parser.ReadFields();
                    var employee = GetEmployeeFromCsvProps(props);
                    employees.Add(employee);
                }
            }

            return employees;
        }

        // Получаем сотрудника из набора свойств csv строки (парсинг сотрудника, частный метод)
        private Employee GetEmployeeFromCsvProps(string[] props)
        {
            int id = int.Parse(props[0]);
            DateTime createdAt = DateTime.Parse(props[1]);
            string fullName = props[2];
            int age = int.Parse(props[3]);
            int height = int.Parse(props[4]);
            string birthDate = props[5];
            string placeOfBirth = props[6];

            var employee = new Employee(
                id,
                createdAt,
                fullName,
                age,
                height,
                birthDate,
                placeOfBirth);

            return employee;
        }

        //public void WriteData()
        //{
        //    string path = @"E:\employees.csv";
        //    using (StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode))
        //    {
        //        char key = 'y';

        //        do
        //        {
        //            string note = string.Empty;
        //            Console.Write("\nВведите ID сотрудника: ");
        //            note += $"{Console.ReadLine()}\t";

        //            string now = DateTime.Now.ToString();
        //            Console.WriteLine($"Дата и время добавления записи: {now}");
        //            note += $"{now}\t";

        //            Console.Write("Ф.И.О: ");
        //            note += $"{Console.ReadLine()}\t";

        //            Console.Write("Возраст: ");
        //            note += $"{Console.ReadLine()}\t";

        //            Console.Write("Рост: ");
        //            note += $"{Console.ReadLine()}\t";

        //            Console.Write("Дата рождения: ");
        //            note += $"{Console.ReadLine()}\t";

        //            Console.Write("Место рождения: ");
        //            note += $"{Console.ReadLine()}\t";
        //            sw.WriteLine(note);
        //            Console.Write("Продолжить y/n"); key = Console.ReadKey(true).KeyChar;
        //        } while (char.ToLower(key) == 'y');
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine($"Файл {path} успешно создан. Нажмите Enter для продолжения\n");
        //    Console.ReadLine();
        //}


    }
}
