using System.Net;
using System.Net.Mail;
using System.Text;

namespace VotingSystem.Models
{
    public class SendNotifications
    {
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;
        string message = string.Empty;
        public string SendEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                login = new NetworkCredential("ncsprojectx", "password001");
                client = new SmtpClient("stmp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage
                {
                    From = new MailAddress("chuzksy@gmail.com", "Chuzksy Solutions", Encoding.UTF8),
                    Subject = "Voters Registration PIN",
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true,
                    Priority = MailPriority.Normal,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };
                client.SendCompleted += Client_SendCompleted;
                const string userstate = "Sending...";
                client.SendAsync(msg, userstate);
            }
            else
            {
                return "Please! Provide an email address";
            }
            return message;
        }

        private void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                message = "Sending email cancelled " + e.UserState;
            }
            if (e.Error != null)
            {
                message = e.UserState + " " + e.Error;
            }
            else
            {
                message = "Your email has been sent successfully";
            }
        }
    }
}
