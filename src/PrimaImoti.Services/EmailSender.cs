using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrimaImoti.Services
{
    public class EmailSender : IEmailSender
    {
        private const string Email = "dim.pramatarov@gmail.com";

        public void SendMail(string mailBody, string senderEmail, string firstName, string lastName, string subject)
        {
            using (var message = new MailMessage(senderEmail, Email))
            {
                message.To.Add(new MailAddress(Email));
                message.From = new MailAddress(senderEmail);
                message.Subject = subject;
                message.Body = $@"Съобщение от {firstName} {lastName} :
                                {mailBody}";


                using (var smtpClient = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "dim.pramatarov@gmail.com",
                        Password = "l1f3isbad940606",
                    };

                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.SendMailAsync(message);
                }

                //send message from localhost



                // send message from host server
                //  using( var smtpClient = new SmtpClient("mail.localhost:41412"))
                //  {
                //      smtpClient.Send(message);
                //  }
            }
        }
    }
}
