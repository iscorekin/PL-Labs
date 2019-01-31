using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Address first = new Address("Петропавловская", 22, 614000, false);
            Address second = new Address("Советская", 33, 614022, true);

            second.ReceiveMessage("Здравствуйте до свидания");
            second.ReceiveMessage("Проверка раз два три");

            first.PrintAddress();
            second.PrintAddress();

            if (second.ReadyToReceive)
            {
                Console.WriteLine("Отправьте сообщение на {0}, {1} и прочитайте другие входящие", second.Street, second.Building);
                second.ReceiveMessage(Console.ReadLine());
                second.PrintMessages();
            }

            Console.ReadKey();
        } 
    }
}
