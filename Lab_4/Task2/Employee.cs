using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee : Person
    {
        public string Company { get; private set; }
        public string Position { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, string surname, int age, Sex sex, string company, string position, int salary)
            : base(name, surname, age, sex)
        {
            Company = company;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($"\nКомпания: {Company}\nДолжность: {Position}\nОклад: {Salary}");
        }
    }
}
