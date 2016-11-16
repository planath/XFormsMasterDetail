using System;
using Xamarin.Forms;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.Model;
using XFormsMasterDetail.View;
using XFormsMasterDetail.View.Cell;

namespace XFormsMasterDetail
{
    class MasterPage : ContentPage
    {
        public Action<object> ItemSelected { get; set; }
        public IListContnent SelectedRowItem { get; set; }
        public MasterPage()
        {
            this.SetBinding(TitleProperty, "Title");

            var list = new ListView();
            list.HasUnevenRows = true;           
            list.SetBinding(ListView.ItemsSourceProperty, "List");
            list.ItemTemplate = new DataTemplate(typeof(ColorViewCell));
            list.ItemSelected += (sender, args) =>
            {
                if (list.SelectedItem == null)
                    return;

                var detail = args.SelectedItem;
                if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
                {
                    if (detail is IListContnent)
                        SelectedRowItem = detail as IListContnent;

                    ItemSelected.Invoke(detail);
                }
                else if (detail is ServerStatus)
                {
                    var serverDetail = detail as ServerStatus;
                    SelectedRowItem = serverDetail;
                    list.SelectedItem = null;
                    Navigation.PushAsync(new DetailView{ BindingContext = serverDetail });
                }
                else if (detail is Setting)
                {
                    var settingDetail = detail as Setting;
                    SelectedRowItem = settingDetail;
                    list.SelectedItem = null;
                    Navigation.PushAsync(new SettingsNotificationPage() {BackgroundColor = Color.Gray});
                }
            };

            Content = list;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop) { 
                ItemSelected.Invoke(SelectedRowItem);
            }
        }
    }
}
