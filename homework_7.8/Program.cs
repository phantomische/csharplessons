using System;

namespace homework_7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository empRep = new EmployeeRepository();
            empRep.WriteData();
            Console.ReadKey();
            
            empRep.ReadData();
        }
    }
}
