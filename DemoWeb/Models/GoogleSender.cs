namespace DemoWeb.Models
{
    public class GoogleSender : ISender
    {
        public string Send(string subject, string body, string destination)
        {
            return "Send By Google => to " + destination + " " + "subject = " + subject + "body = " + body;
        }

    }
}

