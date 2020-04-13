using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        // core business logic 
        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Create: " + product.Operation();


            return result;
        }
    }
}
