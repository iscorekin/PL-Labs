using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty[] facs = new Faculty[5];
            double averageCost = 0;

            for (int i = 0; i < 5; i++)
            {
                facs[i] = InputFaculty();
                averageCost += facs[i].Cost;
            }

            averageCost /= 5;

            for (int i = 0; i < 5; i++)
            {
                if (facs[i].Year >= 2000 && facs[i].Cost < averageCost)
                    Console.WriteLine(facs[i]);
            }
        }

        static Faculty InputFaculty()
        {
            string name;
            int year, amount, cost;

            Console.Write("Название: ");
            name = Console.ReadLine();
            Console.Write("Год основания: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Количество студентов: ");
            amount = int.Parse(Console.ReadLine());
            Console.Write("Стоимость обучения: ");
            cost = int.Parse(Console.ReadLine());

            return new Faculty(name, year, amount, cost);
        }
    }
}
