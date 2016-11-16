
using Xamarin.Forms;
using XFormsMasterDetail.Model;
using XFormsMasterDetail.Repository;
using XFormsMasterDetail.View.Cell;

namespace XFormsMasterDetail
{
    public class SettingsNotificationPage : ContentPage
    {
        public SettingsNotificationPage()
        {
            var listView = new ListView();
            
            listView.ItemTemplate = new DataTemplate(typeof(CheckmarkViewCell));
            listView.ItemsSource = SettingsNotificationRepo.GetData();

            listView.ItemSelected += (sender, args) =>
            {
                foreach (Setting tone in listView.ItemsSource)
                {
                    tone.StyleId = "none";
                }
                (args.SelectedItem as Setting).StyleId = "checkmark";
            };

            Content = listView;
        }
    }
}
