using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Model;
using XFormsMasterDetail.View;

namespace XFormsMasterDetail
{
    class TabletMasterPage : MasterDetailPage
    {
        public TabletMasterPage()
        {
            Master = new TabPage{Title = "Sinalyse"};
            Detail = new PlaceholderPage();

            ((TabPage)Master).ItemSelected = (detail) =>
            {
                if (detail != null && detail is ServerStatus)
                {
                    Detail = new DetailView();
                    Detail.BindingContext = detail;
                }
                else if (detail != null && detail is Setting)
                {
                    Detail = new PlaceholderPage();
                }
                else
                {
                    Detail = new PlaceholderPage();
                }

                if (Device.OS != TargetPlatform.Windows)
                    IsPresented = false;
            };
        }
    }
}
