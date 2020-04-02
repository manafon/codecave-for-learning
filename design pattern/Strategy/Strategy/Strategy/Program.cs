using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class Program
    {
        // Allow changing business logic/algorithm (strategies) at runtime
        // 1. can use it to extract the varying behavior into separate class
        // 2. can isolate business logic 


        static void Main(string[] args)
        {
            var context = new Context();

            Console.Write("Client: Strategy is set to normal sorting");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine("Client: Strategy is set to reverse sorting");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
