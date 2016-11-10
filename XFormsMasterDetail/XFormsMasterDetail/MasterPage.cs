using System;
using Xamarin.Forms;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail
{
    class MasterPage : ContentPage
    {
        public Action<ServerStatus> ItemSelected { get; set; }
        public MasterPage()
        {
            this.SetBinding(TitleProperty, "Title");

            var list = new ListView();
            list.SetBinding(ListView.ItemsSourceProperty, "List");
            list.ItemTemplate = new DataTemplate(typeof(CustomImageCell));
            list.ItemSelected += (sender, args) =>
            {
                //if (args.SelectedItem != null)
                //{
                //    var detailPage = new DetailPage();
                //    detailPage.BindingContext = args.SelectedItem;
                //    list.SelectedItem = null;
                //    Navigation.PushAsync(detailPage);
                //}

                if (list.SelectedItem == null)
                    return;

                var detail = args.SelectedItem as ServerStatus;
                if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
                {
                    ItemSelected.Invoke(detail);
                }
                else
                {
                    Navigation.PushAsync(new DetailPage { BindingContext = detail });
                    list.SelectedItem = null;
                }
            };

            Content = new ScrollView
            {
                Content = list
            };
        }
    }
}
