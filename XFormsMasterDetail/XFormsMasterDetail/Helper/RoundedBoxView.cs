using Xamarin.Forms;

namespace XFormsMasterDetail.Helper
{
    public class RoundedBoxView : BoxView
    {
        public RoundedBoxView()
        {
        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create<RoundedBoxView, double>(p => p.CornerRadius, default(double));

        public double CornerRadius
        {
            get { return (double) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty OutlineColorProperty =
            BindableProperty.Create<RoundedBoxView, Color>(p => p.OutlineColor, default(Color));

        public Color OutlineColor
        {
            get { return (Color)GetValue(OutlineColorProperty); }
            set { SetValue(OutlineColorProperty, value); }
        }
    }
}
