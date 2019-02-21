using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Car
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public int Cost { get; private set; }

        public Car(string name, int year, string color, int cost)
        {
            Name = name;
            Year = year;
            Color = color;
            Cost = cost;
        }

        public override string ToString()
        {
            return String.Format($"{Name}:{Year}:{Color}:{Cost}");
        }
    }
}
