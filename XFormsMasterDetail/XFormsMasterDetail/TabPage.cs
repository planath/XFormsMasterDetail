using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    public class TabPage : TabbedPage
    {
        public Action<ServerStatus> ItemSelected { get; set; }
        public TabPage()
        {
            var context = new RootDataSource();
            //this.BindingContext = context;
            //this.SetBinding(TabbedPage.ItemsSourceProperty, "Tabs");
            
            foreach (var tab in context.Tabs)
            {
                var masterPage = new MasterPage();
                masterPage.BindingContext = tab;
                var navigationPage = new NavigationPage(masterPage) {Title = tab.Title/*, Icon = new FileImageSource{File = ""}*/};
                Children.Add(navigationPage);
            }

            foreach (var childTab in Children)
            {
                var masterPage = ((NavigationPage) childTab).CurrentPage;
                ((MasterPage)masterPage).ItemSelected = (serverStatus) =>
                {
                    ItemSelected.Invoke(serverStatus);
                };
            }
        }

        public IEnumerable<Tab> Tabs { get; set; }
    }
}
