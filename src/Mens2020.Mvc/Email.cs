using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Configuration;

namespace Mens2020.Mvc
{
    public class Email
    {
        public static void Send(string to, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(WebConfigurationManager.AppSettings["senderEmail"], WebConfigurationManager.AppSettings["senderDisplayName"]);
            MailAddress toMailAddress = new MailAddress(to);

            MailMessage mail = new MailMessage(fromMailAddress, toMailAddress);

            mail.ReplyToList.Add(WebConfigurationManager.AppSettings["senderReplyToEmail"]);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Send(mail);
        }
    }
}