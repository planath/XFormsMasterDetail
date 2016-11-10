using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsMasterDetail.Model
{
    public class ServerStatus
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
        }

        public ServerStatus()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Rule { get; set; }
        public string Message { get; set; }
        public string IpDns { get; set; }
        public string AlarmTime { get; set; }
        public string Status { get; set; }
        public string ConfirmationTime { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public Color Color { get; set; }

        #region Repository Service
        public static IEnumerable<ServerStatus> GetData()
        {
            return new List<ServerStatus>{
                new ServerStatus(1, "SiNVR Server", "Lorem ipsum tatafa nare be sodum.", "Plüss", "andi@qlu.ch", RandomDay().ToString(), "ok" + RandomDay(true).ToString() ,RandomDay(true).ToString(), "Andreas P.", "Kommentar1", Color.Green),
                new ServerStatus(2, "Stream Server", "Lorem ipsum tatafa nare be sodum.", "Plüss", "ruedi@qlu.ch", RandomDay().ToString(), "ok" + RandomDay(true).ToString() ,RandomDay(true).ToString(), "Andreas P.", "Kommentar2", Color.Lime),
                new ServerStatus(3, "SiNVR Hybrid", "Lorem ipsum tatafa nare be sodum.", "Plüss", "markus@qlu.ch", RandomDay().ToString(), "ok" + RandomDay(true).ToString() ,RandomDay(true).ToString(), "Andreas P.", "Kommentar3", Color.Green),
                new ServerStatus(4, "MySql Service for multiple internal Databases", "Lorem ipsum tatafa nare be sodum.", "Plüss", "Hinzer@qlu.ch", RandomDay(true).ToString(), "ok" + RandomDay(true).ToString() ,RandomDay().ToString(), "Andreas P.", "Kommentar4", Color.Red),
                new ServerStatus(5, "VM OPC Server", "Lorem ipsum tatafa nare be sodum.", "Plüss", "quala@qlu.ch", RandomDay().ToString(), "ok" + RandomDay(true).ToString() ,RandomDay(true).ToString(), "Andreas P.", "Kommentar5", Color.Yellow)
            };
        }
        public static IEnumerable<ServerStatus> GetRandomData()
        {
            Random rnd = new Random();
            var list = GetData().ToList();
            for (int i = list.Count() - 1; i > 0; --i)
            {
                int j = rnd.Next(i + 1);
                ServerStatus tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
            return list;
        }
        private static DateTime RandomDay(bool history = false)
        {
            Random gen = new Random();
            DateTime start = history ? DateTime.Now.AddHours(-5) : DateTime.Now.AddDays(-8);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        #endregion
    }
}
