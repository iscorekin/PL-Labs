using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Customer
    {
        public string Surname { get; set; }
        public int License { get; set; }
        public DateTime Date { get; set; }
        public string Car { get; set; }
        public string Color { get; set; }
        public float Cost { get; set; }

        public override string ToString()
        {
            return $"{Surname} | {License} | {Date.Day.ToString()}.{Date.Month.ToString()}.{Date.Year.ToString()} | {Car} | {Color} | {Cost}";
        }

        public static float Average(params Customer[] customers)
        {
            float average = 0;

            foreach (var customer in customers)
            {
                average += customer.Cost;
            }

            return average / customers.Length;
        }
    }
}
