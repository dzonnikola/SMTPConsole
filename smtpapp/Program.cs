using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace smtpapp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smptServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("mejlPosiljalaca");
                mail.To.Add("mejlPrimaoca");
                mail.Subject = "Test mail";
                mail.Body = "This is test mail SMTP";

                smptServer.Port = 587;
                smptServer.Credentials = new System.Net.NetworkCredential("username", "password");
                smptServer.EnableSsl = true;

                smptServer.Send(mail);

                Console.WriteLine("Poslato");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Greska :" + ex.Message);
            }
        }
    }
}
