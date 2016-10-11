using System.Net;
using System.Net.Mail;

namespace Tcb.com.ua
{
    public class SendEmail
    {
        public static void sendMail(string recipient, string subject, string body, string attachmentFilename)
        {
            SmtpClient smtpClient = new SmtpClient();
            NetworkCredential basicCredential = new NetworkCredential(MailConst.Username, MailConst.Password);
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(MailConst.Username);

            // setup up the host, increase the timeout to 5 minutes
            smtpClient.Host = MailConst.SmtpServer;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            smtpClient.Timeout = (60 * 5 * 1000);

            message.From = fromAddress;
            message.Subject = subject;
            message.IsBodyHtml = false;
            message.Body = body;
            message.To.Add(recipient);

            if (attachmentFilename != null)
                message.Attachments.Add(new Attachment(attachmentFilename));

            smtpClient.Send(message);
        }
    }
}
