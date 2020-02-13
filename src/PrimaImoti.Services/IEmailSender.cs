using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimaImoti.Services
{
    public interface IEmailSender
    {
        void SendMail(string mailBody,string senderEmail, string subject, string firstName, string lastName);
    }
}
