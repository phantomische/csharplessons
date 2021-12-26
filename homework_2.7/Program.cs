using System;

namespace HomeWork_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Sultan Yerbulatov";
            int age = 41;
            string email = "sultan80@mail.ru";
            double progammingPoints = 2.45;
            double mathPoints = 3.36;
            double physicsPoints = 4.28;
            double totalPoints;
            double averagePoint;

            Console.WriteLine($"Full name is: {fullName} \nAge is: {age} years old " +
                $"\nEmail address is: {email} \nPoints for Programming: {progammingPoints} " +
                $"\nPoints for Mathematics: {mathPoints} \nPoints for Physics: {physicsPoints}.");

            totalPoints = progammingPoints + physicsPoints + mathPoints;
            averagePoint = totalPoints / 3;
            Console.WriteLine($"\nThe total points are: {totalPoints}");
            Console.WriteLine($"The average point is: {averagePoint}");
        }
    }
}
