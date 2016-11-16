using Xamarin.Forms;
using XFormsMasterDetail.Model;

namespace XFormsMasterDetail.View.Cell
{
    class ColorViewCell : ViewCell
    {
        public ColorViewCell()
        {
            var colorIndicatorBox = new BoxView()
            {
                WidthRequest = 8,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            colorIndicatorBox.SetBinding(BoxView.ColorProperty, new Binding("Color"));

            var titleLabel = new Label()
            {
                FontSize = 16,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var subTitleLabel = new Label()
            {
                FontSize = 14,
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Gray
            };
            subTitleLabel.SetBinding(Label.TextProperty, new Binding("SubTitle"));
            
            View = new StackLayout()
            {
                Children =
                {
                    colorIndicatorBox,
                    new StackLayout{ Children = { titleLabel, subTitleLabel }, Spacing = 0, Padding = new Thickness(3, 4), Orientation = StackOrientation.Vertical}
                },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
