namespace DemoWeb.Models
{
    public class YahooSender : ISender
    {
        public string Send(string subject, string body, string destination)
        {
            return "Send By Yahoo => to "+destination+" " + "subject = " + subject + "body = " + body;
        }
    }
}

