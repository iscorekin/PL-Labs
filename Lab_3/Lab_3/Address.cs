using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Address
    {
        public string Street { get; set; }
        public int Building { get; set; } 
        public int Index { get; set; }
        public bool ReadyToReceive { get; set; }
        private List<string> _messages = new List<string>();

        public Address(string street, int building, int index, bool readyToReceive)
        {
            Street = street;
            Building = building;
            Index = index;
            ReadyToReceive = readyToReceive;
        }

        public void PrintAddress()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{Street} | {Building} | {Index}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void PrintMessages()
        {
            Console.WriteLine("\nПолученные сообщения");
            Console.WriteLine("--------------------");

            foreach (string message in _messages)
            {
                Console.WriteLine(message);
                Console.WriteLine("--------------------");
            }
        }

        public void ReceiveMessage(string receivedMessage)
        {
            _messages.Add(receivedMessage);    
        }
    }
}
