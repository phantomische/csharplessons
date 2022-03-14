using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._8
{
    class Employees
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string BirthDate { get; set; }
        public string PlaceOfBirth { get; set; }

        public Employees(int id, DateTime createdAt, string fullName, int age, int height, string birthdate, string placeOfBirth)
        {
            this.ID = id;
            this.CreatedAt = createdAt;
            this.FullName = fullName;
            this.Age = age;
            this.Height = height;
            this.BirthDate = birthdate;
            this.PlaceOfBirth = placeOfBirth; 
        }
    }
}
