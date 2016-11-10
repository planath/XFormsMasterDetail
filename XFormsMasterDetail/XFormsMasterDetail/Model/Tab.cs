using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsMasterDetail.Model
{
    public class Tab
    {
        private static int _index = 0;
        public Tab()
        {
            Index = _index;
            _index++;
        }

        public Tab(string title, IEnumerable<ServerStatus> list)
        {
            Title = title;
            List = list;
            Index = _index;
            _index++;
        }

        public int Index { get; private set; }
        public int? SelectedRow { get; set; }
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
