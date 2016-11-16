using Xamarin.Forms;
using XFormsMasterDetail.Helper;

namespace XFormsMasterDetail.Model
{
    public class ServerStatus : IListContnent
    {
        public ServerStatus(int id, string title, string rule, string message, string ipDns, string alarmTime, string status, string confirmationTime, string user, string comment, Color color)
        {
            Id = id;
            Rule = rule;
            Message = message;
            IpDns = ipDns;
            AlarmTime = alarmTime;
            Status = status;
            ConfirmationTime = confirmationTime;
            User = user;
            Comment = comment;
            Color = color;
            Title = title;
            StyleId = "disclosure";
        }

        public ServerStatus()
        {
            StyleId = "none";
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get { return IpDns; } }
        public string StyleId { get; set; }
        public string Grouping { get; set; }
        public object Data { get; set; }
        public string Rule { get; set; }
        public string Message { get; set; }
        public string IpDns { get; set; }
        public string AlarmTime { get; set; }
        public string Status { get; set; }
        public string ConfirmationTime { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public Color Color { get; set; }
    }
}
