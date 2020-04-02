using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        // maintain a reference to one of strategy objects
        // should work with all strateies
        private IStrategy _strategy;

        public Context()
        { }

        // Constructor that accept a strategy 
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // settor that allows at runtime
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy");

            // call the strategy but dont know its method
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
