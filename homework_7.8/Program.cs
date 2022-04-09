using System;

namespace homework_7._8
{
    class Program
    {
        static void Main(string[] args)
        {    
            var employeeRepository = new EmployeeRepository();
            var NewList = employeeRepository.Update(new Employee(6, DateTime.Now, "Putin Vladimir Bunkerovich", 70, 160, "1953", "Leningrad"));
           

            
        }
    }
}
