using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Client.ClientCode(new ConcreteClass2());

            Console.ReadLine();
        }
    }
}
