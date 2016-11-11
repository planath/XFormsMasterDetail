using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Model;

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
                    Detail = new DetailPage();
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
