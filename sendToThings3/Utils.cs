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
                    mail.From = new MailAddress("owaygaming@gmail.com");
                    mail.To.Add("add-to-things-ibceapkmpr1es4urwx5@things.email");
                    mail.Subject = title;
                    mail.Body = message;
                    //mail.IsBodyHtml = true;
                    // mail.Attachments.Add(new Attachment("C:\\file.zip"));

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("owaygaming@gmail.com", "justinistscheisse");
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
