using System.Collections.Generic;
using System.Linq;
using XFormsMasterDetail.Helper;

namespace XFormsMasterDetail.Model
{
    public static class SettingsRepo
    {
        public static IEnumerable<IListContnent> GetData()
        {
            return new List<Setting>{
                new Setting("Über Sinalyse"),
                new Setting("Server"),
                new Setting("Login"),
                new Setting("Status"),
                new Setting("Benachrichtigungston"),
                new Setting("Daten via E-Mail senden"),
                new Setting("Daten löschen")
            };
        }
    }
}