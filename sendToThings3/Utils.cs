using System;
using System.Net;
using System.Net.Mail;

namespace sendToThings3
{
    class Utils
    {
        public static bool SendMail(string title, string message)
        {
            string thingsMail = Storage.GetSetting("thingsMail");
            string senderMail = Storage.GetSetting("senderMail");
            string senderPassword = Storage.GetSetting("senderPassword");

            if (thingsMail == null | senderMail == null | senderPassword == null)
            {
                //TODO openSettings
                return false;
            }

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderMail);
                    mail.To.Add(thingsMail);
                    mail.Subject = title;
                    mail.Body = message;
                    //mail.IsBodyHtml = true;
                    // mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(senderMail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

    }
}
