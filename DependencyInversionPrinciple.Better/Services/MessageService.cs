using DependencyInversionPrinciple.Better.Domain;
using DependencyInversionPrinciple.Better.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Better.Services
{
    public class MessageService : IMessageService
    {
        public ISmsSender SmsSender { get; private set; }

        public MessageService(ISmsSender smsSender)
        {
            SmsSender = smsSender;
        }

        public void Process(object messageInformations)
        {
            this.SmsSender.Send(messageInformations);
        }
    }
}
