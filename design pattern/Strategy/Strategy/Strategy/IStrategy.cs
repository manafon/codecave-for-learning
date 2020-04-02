using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Strategy interface
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
