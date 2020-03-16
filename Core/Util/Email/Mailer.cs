using Core.Util.Email.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core.Util.Email
{
    public class Mailer : IMailer
    {
        public void sendEmail(string to, string subject, string body)
        {

           

            try
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                mailMessage.From = new MailAddress("franciscoantoniogarciaquintana@gmail.com");

                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                var smtpClient = new SmtpClient();
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
            catch (Exception e) {

            }
        }
    }
}
