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
            Polynomial p1 = InitPolynomial();
            Polynomial p2 = InitPolynomial();

            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 * p2);
            Console.WriteLine(p1 == p2);

            Polynomial p3 = p1 + p2;
            Console.WriteLine(p3);

            Console.WriteLine(p1.Calculate(1.2));
            Console.ReadKey();
        }

        public static Polynomial InitPolynomial()
        {
            List<double> coefs = new List<double>();
            double input;

            Console.WriteLine("Введите коэффициенты для многочлена, конец ввода - 0: ");
            input = Double.Parse(Console.ReadLine());

            while (input != 0)
            {
                coefs.Add(input);
                input = Double.Parse(Console.ReadLine());
            }

            return new Polynomial(coefs.ToArray());
        }
    }
}
