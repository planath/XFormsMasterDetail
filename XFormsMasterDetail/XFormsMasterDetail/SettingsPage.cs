using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            // List from binding (no grouping)
            //var list = new ListView();
            ////list.SetBinding(ListView.ItemsSourceProperty, "");
            //list.IsGroupingEnabled = true;
            //list.GroupDisplayBinding = new Binding("Grouping");
            //list.ItemTemplate = new DataTemplate(typeof(BindingTextCell));

            // List without binding (with grouping)
            var listView = new ListView
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Category"),
                GroupShortNameBinding = new Binding("Category")
            };


            listView.ItemTemplate = new DataTemplate(typeof(BindingTextCell));

            listView.ItemsSource = new[] {
                new Group("About") {
                    new Setting("Über Sinalyse"),
                },
                new Group("Server") {
                    new Setting("Server"),
                    new Setting("Login"),
                    new Setting("Status")
                },
                new Group("Notification") {
                    new Setting("Benachrichtigungston")
                },
                new Group("Data") {
                    new Setting("Daten löschen"),
                    new Setting("Daten via E-Mail senden")
                },
            };

            Content = listView;
        }
    }
}
