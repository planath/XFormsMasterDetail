using Xamarin.Forms;

namespace XFormsMasterDetail
{
    public class PlaceholderPage : ContentPage
    {
        public PlaceholderPage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label {Text = "Eintrag wählen", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))}
                }
            };
        }
    }
}