using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Better.Domain
{
    public interface IMessageService
    {
        void Process(object messageInformations);
    }
}
