using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /**
     * Mediator 
     * Behavior Pattern
     * Use for communicatinon
     * Provide isolation, each component must not aware of other components
     * 
     * Solve Problems:
     * 1. Too hard to change some classes due to gihtly coupled
     * 2. Too many component subclasses,
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Component contain business logic
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A");
            component1.DoA();

            Console.WriteLine("Client triggers operation D");
            component2.DoD();

            Console.ReadLine();

        }
    }
}
