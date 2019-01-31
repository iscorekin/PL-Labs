using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0
{
    class Program
    {
        static void Main()
        {
            int Mathematics, Physics, Biology;
            Mathematics = int.Parse(Console.ReadLine());
            Physics = int.Parse(Console.ReadLine());
            Biology = int.Parse(Console.ReadLine());
            string str_1, str_2;
            str_1 = "\aКонъюнкция: ";
            str_2 = "Дизъюнкция: ";
            if (Mathematics == 5 && Physics == 5 && Biology == 5) { str_1 += "Отличник"; } else { str_1 += "Двоечник"; }
            if (Mathematics == 5 || Physics == 5 || Biology == 5) { str_2 += "Молодец"; } else { str_2 += "Лентяй"; }
            Console.WriteLine(str_1);
            Console.WriteLine(str_2);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }

    }
}
