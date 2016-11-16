
using Xamarin.Forms;

namespace XFormsMasterDetail.View.Cell
{
    public class CheckmarkViewCell : ViewCell
    {
        public static readonly BindableProperty StyleIdProperty =
          BindableProperty.Create("StyleId", typeof(string), typeof(CheckmarkViewCell), "");

        public string StyleId
        {
            get { return (string)GetValue(StyleIdProperty); }
            set { SetValue(StyleIdProperty, value); }
        }

        public CheckmarkViewCell()
        {
            this.SetBinding(StyleIdProperty, "StyleId");
            
            var titleLabel = new Label()
            {
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var subTitleLabel = new Label()
            {
                FontSize = 16
            };
            subTitleLabel.SetBinding(Label.TextProperty, new Binding("SubTitle"));

            View = new StackLayout()
            {
                Children =
                {
                    titleLabel, subTitleLabel
                },
                Orientation = StackOrientation.Vertical
            };
        }
    }
}
