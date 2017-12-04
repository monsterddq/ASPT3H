using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        public static void sendMail()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587; //587 gmail
            client.Host = "smtp.gmail.com"; //smtp.gmail.com
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("aspnet.core001@gmail.com", "@1234qwer@");
            MailMessage cm = new MailMessage();
            cm.From = new MailAddress("Mail Test");
            cm.To.Add("doanquocthai.it@gmail.com");
            cm.Subject = "Chu de mail";
            cm.Body = "Noi dung mail";
            cm.IsBodyHtml = true;
            cm.BodyEncoding = UTF8Encoding.UTF8;
            cm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            try
            {
                client.Send(cm);
            }
            catch
            {
            }
        }
    }