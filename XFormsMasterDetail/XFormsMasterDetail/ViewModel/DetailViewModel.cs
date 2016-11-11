using System.ComponentModel;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail.ViewModel
{
    public class DetailViewModel : BaseViewModel
    {
        private ServerStatus _serverStatus;

        public DetailViewModel()
        {
        }

        public ServerStatus ServerStatus
        {
            get { return _serverStatus; }
            set { SetField(ref _serverStatus, value, "ServerStatus"); }
        }
    }
}
