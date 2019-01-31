using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i < 1000; i++)
            {
                if ((i % 11 == 0) &&(i % 2 == 0))
                    Console.WriteLine("\a" + i);
            }
            Console.ReadKey();
        }
    }
}
