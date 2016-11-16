using System.ComponentModel;
using XFormsMasterDetail.Helper;

namespace XFormsMasterDetail.Model
{
    public class Setting : IListContnent, INotifyPropertyChanged
    {
        private const string _localImageNameForCheckedIcon = "check.png";
        private string _checkedImage;
        public Setting(string title, bool check)
        {
            Title = title;
            Checked = check;
        }
        public Setting(string title)
        {
            Title = title;
        }
        public Setting()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string CheckedImage
        {
            get { return _checkedImage; }
            set
            {
                _checkedImage = value;
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("CheckedImage"));
            }
        }

        public bool Checked
        {
            get
            {
                return CheckedImage.Equals(_localImageNameForCheckedIcon);
            }
            set
            {
                if (value)
                {
                    CheckedImage = _localImageNameForCheckedIcon;
                }
                else
                {
                    CheckedImage = null;
                }
            }
        }
    }
}
