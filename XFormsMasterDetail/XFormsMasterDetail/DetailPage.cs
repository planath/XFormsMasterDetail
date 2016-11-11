using Xamarin.Forms;

namespace XFormsMasterDetail
{
    class DetailPage : ContentPage
    {
        public DetailPage()
        {
            var label1 = new Label();
            label1.SetBinding(Label.TextProperty, "Title");
            var label2 = new Label();
            label2.SetBinding(Label.TextProperty, "SubTitle");
            var label3 = new Label();
            label3.SetBinding(Label.TextProperty, "Grouping");

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0,30,0,0),
                Spacing = 10,
                Children = {label1, label2, label3}
            };
        }
    }
}
