using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Faculty
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Amount { get; private set; }
        public int Cost { get; private set; }
        

        /// <param name="name">Название факультета</param>
        /// <param name="year">Год основания</param>
        /// <param name="amount">Количество студентов</param>
        /// <param name="cost">Стоимость обучения</param>
        public Faculty(string name, int year, int amount, int cost)
        {
            Name = name;
            Year = year;
            Amount = amount;
            Cost = cost;
        }

        public override string ToString()
        {
            return String.Format($"Название: {Name}\nГод основания: {Year}\nКоличество студентов: {Amount}\nСтоимость обучения: {Cost}");
        }
    }
}
