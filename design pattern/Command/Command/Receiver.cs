using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Receiver
    {
        // Contain business logic class
        // perform operation
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Woring on (${a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on(${b}.)");
        }
    }
}
