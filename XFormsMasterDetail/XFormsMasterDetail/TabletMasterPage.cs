using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.Model;
using XFormsMasterDetail.View;

namespace XFormsMasterDetail
{
    class TabletMasterPage : MasterDetailPage
    {
        public TabletMasterPage()
        {
            Master = new TabPage{Title = "Sinalyse" };
            Detail = new PlaceholderPage();

            ((TabPage)Master).ItemSelected = (detail) =>
            {
                if (detail != null && detail is ServerStatus)
                {
                    Detail = new NavigationPage(new DetailView()) { BarBackgroundColor = new Color().AppMainColor(), BarTextColor = Color.White };
                    Detail.BindingContext = detail;
                }
                else if (detail != null && detail is Setting)
                {
                    Detail = new NavigationPage(new SettingsNotificationPage() { BackgroundColor = Color.FromHex("eeeeea") }) { BarBackgroundColor = new Color().AppMainColor(), BarTextColor = Color.White };
                }
                else
                {
                    Detail = new NavigationPage(new PlaceholderPage()) {BarBackgroundColor = new Color().AppMainColor(), BarTextColor = Color.White};
                }

                if (Device.OS != TargetPlatform.Windows)
                    IsPresented = false;
            };
        }
    }
}
