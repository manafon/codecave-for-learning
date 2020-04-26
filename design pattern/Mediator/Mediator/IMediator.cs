using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // Mediator interface
    // delares methods of communication 
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
