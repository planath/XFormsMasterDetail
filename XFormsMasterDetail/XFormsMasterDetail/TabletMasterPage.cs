using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    class TabletMasterPage : MasterDetailPage
    {
        public TabletMasterPage()
        {
            Title = "Tablet optimized";
            Master = new MasterPage() {BindingContext = Tab.GetTabs().FirstOrDefault()};

            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Children =
                        {
                          new Label { Text = "Select a Shop", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
                        }
                }
            };

            ((MasterPage)Master).ItemSelected = (serverStatus) =>
            {
                Detail = new DetailPage();
                Detail.BindingContext = serverStatus;
                if (Device.OS != TargetPlatform.Windows)
                    IsPresented = false;
            };

        }
    }
}
