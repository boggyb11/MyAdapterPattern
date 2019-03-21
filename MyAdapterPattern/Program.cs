using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new DebitCard();
            CardReader client = new CardReader(target);
            client.TakePayment(100);

            Console.ReadKey();
        }
    }
}
