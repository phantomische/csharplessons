using System;
using System.Linq;

namespace homework_7._8
{
    class Program
    {
        static void Main(string[] args)
        {    
            var employeeRepository = new EmployeeRepository();

            var employeesSort = employeeRepository.GetAll().OrderBy(e => e.CreatedAt);
            foreach (var employee in employeesSort)
            {
                Console.WriteLine(employee.ID + " " +
                    employee.CreatedAt + " " +
                    employee.FullName + " " +
                    employee.Age + " " +
                    employee.Height + " " +
                    employee.BirthDate + " " +
                    employee.PlaceOfBirth);
            }
            Console.ReadKey();
            
            Console.WriteLine("Введите диапозон дат");
            var employeeCA = (Console.ReadLine());
            var employeesRange = employeeRepository.GetAll().Where(e => e.CreatedAt >= DateTime.Parse(employeeCA) 
                                                            && e.CreatedAt <= DateTime.Parse(employeeCA));
            foreach (var employee in employeesRange)
            {
                Console.WriteLine(employee.ID + " " +
                    employee.CreatedAt + " " +
                    employee.FullName + " " +
                    employee.Age + " " +
                    employee.Height + " " +
                    employee.BirthDate + " " +
                    employee.PlaceOfBirth);
            }

        }
    }
}
