using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /**
     * Behavioral Patterns
     * Make command/operation into objects so it can queue, schedule, redo...
     * 
     * Solve Problems:
     * 1. parametrize object with operations, configuring executions
     * 2. Provide queue operation, schedule execution,  redo, storing executions
     */
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            // configure the command but not send it 
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();

            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            // trigger the command
            invoker.DoSomethingImportant();
            Console.ReadLine();
        }
    }
}
