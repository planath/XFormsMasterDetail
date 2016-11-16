using Xamarin.Forms;

namespace XFormsMasterDetail.View.Cell
{
    public class CheckmarkViewCell : ViewCell
    {
        public CheckmarkViewCell()
        {
            var titleLabel = new Label()
            {
                FontSize = 16,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var checkbox = new Image();
            checkbox.SetBinding(Image.SourceProperty, "CheckedImage");
            checkbox.WidthRequest = 24;
            
            View = new StackLayout()
            {
                Children =
                {
                    titleLabel, checkbox
                },
                Padding = new Thickness(20, 0, 12, 0),
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
