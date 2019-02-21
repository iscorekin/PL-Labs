using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            double average = 0;

            using (StreamReader reader = new StreamReader("C:\\test\\cars.txt"))
            {
                string[] info = new string[]{ };

                for (int i = 0; i < 5; i++)
                {
                    info = reader.ReadLine().Split(':');
                    cars[i] = new Car(info[0], int.Parse(info[1]), info[2], int.Parse(info[3]));
                    average += cars[i].Cost;
                }

                average /= 5;
            }
            
            using (StreamWriter writer = new StreamWriter("C:\\test\\cars_out.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (cars[i].Year >= 2013 && cars[i].Cost < average)
                        writer.WriteLine(cars[i]);
                }
            }
        }
    }
}
