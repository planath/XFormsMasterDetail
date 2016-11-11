using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    public class TabPage : TabbedPage
    {
        public Action<object> ItemSelected { get; set; }
        public List<Tab> Tabs { get; set; }
        public Tab CurrentTab { get; set; }

        public TabPage()
        {
            var tabs = MainDataRepo.GetTabLists();
            foreach (var tab in tabs)
            {
                var masterPage = new MasterPage();
                masterPage.BindingContext = tab;
                var navigationPage = new NavigationPage(masterPage) {Title = tab.Title, BarBackgroundColor = new Color().AppMainColor(), BarTextColor = Color.White};
                Children.Add(navigationPage);
            }

            foreach (var childTab in Children)
            {
                var masterPage = ((NavigationPage) childTab).CurrentPage;
                ((MasterPage)masterPage).ItemSelected = (detail) =>
                {
                    ItemSelected.Invoke(detail);
                };
            }
        }
    }
}
