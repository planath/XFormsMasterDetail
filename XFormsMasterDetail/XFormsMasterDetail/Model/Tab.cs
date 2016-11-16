using System.Collections.Generic;
using XFormsMasterDetail.Helper;

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

        public Tab(string title, IEnumerable<IListContnent> list)
        {
            Title = title;
            List = list;
            Index = _index;
            _index++;
        }

        public int Index { get; private set; }
        public int? SelectedRow { get; set; }
        public string Title { get; set; }
        public IEnumerable<IListContnent> List { get; set; }
    }
}
