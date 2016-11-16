using System.Collections.Generic;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail.Repository
{
    public static class SettingsNotificationRepo
    {
        public static IEnumerable<Setting> GetData()
        {
            return new List<Setting>{
                new Setting("Sinalyse-Ton"),
                new Setting("Server-Ton"),
                new Setting("Login-Ton"),
                new Setting("Status-Ton", true),
                new Setting("Benachrichtigungston"),
                new Setting("Daten-Ton")
            };
        }
    }
}
