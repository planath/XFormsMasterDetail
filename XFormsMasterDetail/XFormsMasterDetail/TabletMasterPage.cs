using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    class TabletMasterPage : MasterDetailPage
    {
        public TabletMasterPage()
        {
            Master = new TabPage{BindingContext = Tab.GetTabs(), Title = "Tablet optimized", BackgroundColor = Color.Red};

            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Children =
                        {
                          new Label { Text = "Eintrag wählen", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
                        }
                },
                BackgroundColor = Color.Blue
            };

            ((TabPage)Master).ItemSelected = (serverStatus) =>
            {
                Detail = new DetailPage();
                Detail.BindingContext = serverStatus;
                if (Device.OS != TargetPlatform.Windows)
                    IsPresented = false;
            };

        }
    }
}
