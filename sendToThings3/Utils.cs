using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace sendToThings3
{
    class Utils
    {
        public static MailStatus SendMail(string title, string message)
        {
            string thingsMail = Storage.GetSetting("thingsMail");
            string senderMail = Storage.GetSetting("senderMail");
            string senderPassword = Storage.GetSetting("senderPassword");
            string smtpClientHost = Storage.GetSetting("smtpHost");
            string smtpClientPort = Storage.GetSetting("smtpPort");

            if (thingsMail == null | senderMail == null | senderPassword == null | smtpClientHost == null | !int.TryParse(smtpClientPort, out var smtpClientPortInt))
            {
                return MailStatus.SettingsError;
            }

            

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderMail);
                    mail.To.Add(thingsMail);
                    mail.Subject = title;
                    mail.Body = message;

                    using (var smtp = new SmtpClient(smtpClientHost, smtpClientPortInt))
                    {
                        smtp.Credentials = new NetworkCredential(senderMail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        return MailStatus.Ok;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return MailStatus.NetworkError;
            }

        }

        public enum MailStatus : uint
        {
            Ok = 1,
            SettingsError = 2,
            NetworkError = 3,
        }

    }
}
