using System.Windows.Input;
using Xamarin.Forms;

namespace XFormsMasterDetail.ViewModel
{
    class ServerListViewModel : BaseViewModel
    {
        public ServerListViewModel()
        {
            ItemSelectedCommand = new Command<string>((key) =>
            {
            });
        }

        public ICommand ItemSelectedCommand { protected set; get; }
    }
}
