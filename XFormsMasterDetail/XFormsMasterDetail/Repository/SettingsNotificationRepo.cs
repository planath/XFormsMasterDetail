using System.Collections.Generic;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail.Repository
{
    public static class SettingsNotificationRepo
    {
        public static IEnumerable<Setting> GetData()
        {
            return new List<Setting>{
                new Setting("Sinalyse-Ton", "", "none"),
                new Setting("Server-Ton", "", "none"),
                new Setting("Login-Ton", "", "none"),
                new Setting("Status-Ton", "", "checkmark"),
                new Setting("Benachrichtigungston", "", "none"),
                new Setting("Daten-Ton", "", "none")
            };
        }
    }
}
