using System.Collections.Generic;
using System.Linq;

namespace XFormsMasterDetail.Model
{
    class Setting : IListContnent
    {
        private static int _index = 0;
        public Setting(string title, string category)
        {
            Title = title;
            Category = category;
            Id = _index;
            _index++;
        }
        public Setting(string title)
        {
            Title = title;
            Id = _index;
            _index++;
        }
        public Setting()
        {
            Id = _index;
            _index++;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Category { get; set; }
    }
}
