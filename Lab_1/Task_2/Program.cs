using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double a;
            for (int i = 0; i < 6; i++)
            {
                a = Math.Pow(-1, i - 1) / Math.Pow(i, i);
                Console.WriteLine("{0:0.0000}", Sum);
                Sum += a;
            }
            Console.WriteLine("{0:0.0000}", Sum);
            Console.ReadKey();
        }
    }
}
