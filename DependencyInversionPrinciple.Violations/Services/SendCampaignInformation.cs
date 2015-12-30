using DependencyInversionPrinciple.Violations.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Violations.Services
{
    public class SendCampaignInformation
    {
        public MailSender MailSender { get; private set; }

        public SendCampaignInformation(MailSender mailSender)
        {
            this.MailSender = mailSender;
        }

        public void SendMail(object data)
        {
            this.MailSender.SendMail(data);
        }
    }
}
