using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsMasterDetail.Model
{
    public class RootDataSource
    {
        public RootDataSource()
        {
            Tabs = Tab.GetTabs();
        }

        public Tab CurrentTab { get; set; }
        public IEnumerable<Tab> Tabs { get; set; }
    }
}
