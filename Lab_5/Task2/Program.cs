using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[10];
            List<Customer> Ladas = new List<Customer>();

            using (StreamReader reader = new StreamReader("C:\\test\\customers.txt"))
            {
                string[] info = new string[] { };

                for (int i = 0; i < 10; i++)
                {
                    info = reader.ReadLine()?.Split(':');
                    customers[i] = new Customer()
                    {
                        Surname = info[0],
                        License = int.Parse(info[1]),
                        Date = DateTime.Parse(info[2]),
                        Car = info[3],
                        Color = info[4],
                        Cost = float.Parse(info[5])
                    };
                }
            }

            for (int i = 0; i < 10; i++)
            {
                int k = 0;

                if (customers[i].Car == "Lada")
                {
                    Ladas.Add(customers[i]);
                }
            }

            for (int i = 0; i < Ladas.Count; i++)
            {
                for (int j = 0; j < Ladas.Count - 1; j++)
                {
                    if (Ladas[j].Cost < Ladas[j + 1].Cost)
                    {
                        var z = Ladas[j];
                        Ladas[j] = Ladas[j + 1];
                        Ladas[j + 1] = z;
                    }
                }
            }

            for (int i = 0; i < Ladas.Count; i++)
                Console.WriteLine(Ladas[i].ToString());

            using (StreamWriter writer = new StreamWriter("C:\\test\\customers_out.txt"))
            {
                Customer cmin = customers[0];
                Customer cmax = customers[0];

                writer.WriteLine(Customer.Average(customers));

                for (int i = 1; i < 10; i++)
                {

                    if (customers[i].Cost < cmin.Cost)
                    {
                        cmin = customers[i];
                    }

                    if (customers[i].Cost > cmax.Cost)
                    {
                        cmax = customers[i];
                    }
                }

                writer.WriteLine(cmin.ToString());
                writer.WriteLine(cmax.ToString());
            }

            Console.ReadKey();
        }
    }
}
