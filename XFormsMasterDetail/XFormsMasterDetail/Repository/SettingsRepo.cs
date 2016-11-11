using System.Collections.Generic;
using System.Linq;

namespace XFormsMasterDetail.Model
{
    public static class SettingsRepo
    {
        public static IEnumerable<IListContnent> GetData()
        {
            return new List<Setting>{
                new Setting("Über Sinalyse", "About"),
                new Setting("Server", "Server"),
                new Setting("Login", "Server"),
                new Setting("Status", "Server"),
                new Setting("Benachrichtigungston", "Notification"),
                new Setting("Daten via E-Mail senden", "Data"),
                new Setting("Daten löschen", "Data")
            };
        }
    }
}