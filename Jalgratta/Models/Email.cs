using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Jalgratta.Models
{
    public class Email
    {
        public async void SendEmailDefault(string Data, string email)
        {
            try
            {

                MailMessage message = new MailMessage();

                message.IsBodyHtml = true;
                message.From = new MailAddress("citybee24@hotmail.com", "citybee");
                message.To.Add(email);
                message.To.Add("citybee24@hotmail.com");
                message.Subject = "ASP.NET";
                message.Body = "<div style=\"\">Tere, Äitah! et broneeritud, helistame teile sobival ajal" + Data + ". Soovime teile parimat päeva</div>";

                var client = new SmtpClient("smtp.office365.com", 587)
                {
                    Credentials = new NetworkCredential("citybee24@hotmail.com", "citybee24!"),
                    EnableSsl = true
                };
                client.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
