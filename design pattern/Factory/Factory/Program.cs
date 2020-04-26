using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /**
     * Factory
     * Creational Pattern
     * 
     * Solve Problems:
     * 1. Separte construction code from operation logic, easier to extend the code base 
     *      (if need to support new product type, only need to create new creator subclass)
     * 2. Provide override of creation method so to extend internal components
     */
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Run();

            Console.ReadLine();
        }
    }
}
