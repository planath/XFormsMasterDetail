using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsMasterDetail.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageRenderer))]
namespace XFormsMasterDetail.iOS
{
    public class TabbedPageRenderer : TabbedRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            TabBar.TintColor = UIColor.FromRGB(0, 153, 153);
            //TabBar.BarTintColor = UIColor.FromRGB(108, 232, 165); -> BarBackground
            TabBar.BackgroundColor = UIColor.White;
        }
    }
}