using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] ems =
            {
                new Employee("Виктор", "Салеев", 20, Sex.Male, "Леруа", "Менеджер по обоям", 9000),
                new Employee("Никита", "Искоркин", 18, Sex.Male, "Смартанал", "Погромист", 300000),
                new Employee("Аделаида", "Дроздова", 64, Sex.Female, "Газпром", "Главный бухгалтер", 35000),
                new Employee("Актиний", "Речной", 34, Sex.Male, "Веселый водовоз", "Курьер", 13000),
                new Employee("Алёна", "Бутылкина", 90, Sex.Female, "Леруа", "Промоутер в костюме сосиски", 50000),
            };

            for (int i = 0; i < ems.Length; i++)
            {
                if (ems[i].Company == "Леруа" && ems[i].Sex == Sex.Female)
                {
                    Console.WriteLine(ems[i]);
                    Console.WriteLine("--------------------------");
                }
            }

            for (int i = 0; i < ems.Length; i++)
            {
                if (ems[i].Company == "Леруа" && ems[i].Sex == Sex.Male)
                {
                    Console.WriteLine(ems[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
