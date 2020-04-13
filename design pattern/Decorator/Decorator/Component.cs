using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Common interface for both wrapper and wrapped objects
    public abstract class Component
    {
        public abstract string Operation();
    }
}
