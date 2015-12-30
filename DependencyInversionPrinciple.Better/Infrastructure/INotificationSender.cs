using DependencyInversionPrinciple.Better.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Better.Infrastructure
{
    public class INotificationSender : ISender
    {
        public void Send(object data)
        {
            throw new NotImplementedException();
        }
    }
}
