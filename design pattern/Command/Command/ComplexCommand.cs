using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // command implementation with complex operation
    // that need to delegate to  other objects (receiver)
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a;
        private string _b;

        // accept receiver objects and context data
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        // receiver do the actual job
        public void Execute()
        {
            Console.WriteLine("ComplexCommand");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
