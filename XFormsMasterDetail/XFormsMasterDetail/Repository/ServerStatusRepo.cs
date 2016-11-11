using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XFormsMasterDetail.Model
{
    public static class ServerStatusRepo
    {
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

        public static ServerStatus GetDataById(int id)
        {
            var list = GetData().ToList();
            return list.FirstOrDefault(s => s.Id == id);
        }

        private static DateTime RandomDay(bool history = false)
        {
            Random gen = new Random();
            DateTime start = history ? DateTime.Now.AddHours(-5) : DateTime.Now.AddDays(-8);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}