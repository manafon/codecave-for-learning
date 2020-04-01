using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client code
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();

            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadLine();

        }
    }
}
