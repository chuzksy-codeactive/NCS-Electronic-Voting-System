using System.Net;
using System.Net.Mail;

namespace VotingSystem.Models
{
    public class SendNotifications
    {
        public static string SendEmail(string email, string body)
        {
            if (string.IsNullOrWhiteSpace(email)) return "Please! Provide an email address";
            var mail = new MailMessage("chuzksy@gmail.com", email, "Voter Registration Pin", body);
            var client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential("ncsprojectx@gmail.com", "password001");
            client.EnableSsl = true;
            client.Send(mail);
            return "Email was sent successfull to the receipient";
        }
    }
}
