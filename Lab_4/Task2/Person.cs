using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Sex
    {
        Female,
        Male
    }

    class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public Sex Sex { get; private set; }

        public Person(string name, string surname, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return String.Format($"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nПол: {GetSex(this.Sex)}");
        }

        public static string GetSex(Sex sex)
        {
            if (sex == Sex.Female)
            {
                return "Женский";
            }
            else
            {
                return "Мужской";
            }
        }
    }
}
