using System.Collections.ObjectModel;

namespace XFormsMasterDetail.Helper
{
    public class Group : ObservableCollection<IListContnent>
    {
        public Group(string category)
        {
            Category = category;
        }

        public string Category{ get; private set; }
    }
}
