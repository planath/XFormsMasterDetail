using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsMasterDetail.Model
{
    public class Tab
    {
        public Tab()
        {
        }

        public Tab(string title, IEnumerable<ServerStatus> list)
        {
            Title = title;
            List = list;
        }

        public string Title { get; set; }
        public IEnumerable<ServerStatus> List { get; set; }

        #region Repository Service
        public static IEnumerable<Tab> GetTabs()
        {
            return new List<Tab>
            {
                new Tab("Aktuell", ServerStatus.GetRandomData()),
                new Tab("History", ServerStatus.GetRandomData()),
                new Tab("Einstellungen", ServerStatus.GetRandomData())
            };
        }
        #endregion

    }
}
