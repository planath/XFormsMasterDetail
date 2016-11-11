using System.Collections.Generic;

namespace XFormsMasterDetail.Model
{
    public static class MainDataRepo
    {
        public static IEnumerable<Tab> GetTabLists()
        {
            return new List<Tab>
            {
                new Tab("Aktuell", ServerStatusRepo.GetRandomData()),
                new Tab("History", ServerStatusRepo.GetRandomData()),
                new Tab("Einstellungen", SettingsRepo.GetData())
            };
        }
    }
}