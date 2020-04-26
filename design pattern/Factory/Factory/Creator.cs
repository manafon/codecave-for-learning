using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /**
     * Declares factory method, supposed to return object of Product class
     */
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        // core business logic 
        public string SomeOperation()
        {
            // Create product object
            var product = FactoryMethod();

            var result = "Create: " + product.Operation();


            return result;
        }
    }
}
