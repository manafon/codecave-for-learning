using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // Command implementation with simple operation
    class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(String payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand Execute");
        }
    }
}
