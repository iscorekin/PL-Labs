using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        public static void Delete(ref int[] data, int delIndex)
        {
            int[] newData = new int[data.Length - 1];
            for (int i = 0; i < delIndex; i++)
            {
                newData[i] = data[i];
            }
            for (int i = delIndex; i < newData.Length; i++)
            {
                newData[i] = data[i + 1];
            }
            data = newData;
        }

        static void Main(string[] args)
        {
            int[] mas = new int[10]{ 0, 1, 5, 7, 2, 12, 6, 7, 11, 5};

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("\nInput K to delete: ");

            Delete(ref mas, int.Parse(Console.ReadLine()));
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Array.Resize(ref mas, mas.Length + 1);
                    for (int j = mas.Length - 1; j > i + 1; j--)
                    {
                        mas[j] = mas[j - 1];
                    }
                    mas[i + 1] = 0;
                    i++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
