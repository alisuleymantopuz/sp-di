using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Better.Domain
{
    public interface ISender
    {
        void Send(object data);

    }
}
