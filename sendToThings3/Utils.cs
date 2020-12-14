using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace sendToThings3
{
    class Utils
    {
        public static bool SendMail(string title, string message)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("***REMOVED***");
                    mail.To.Add("***REMOVED***");
                    mail.Subject = title;
                    mail.Body = message;
                    //mail.IsBodyHtml = true;
                    // mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("***REMOVED***", "***REMOVED***");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
