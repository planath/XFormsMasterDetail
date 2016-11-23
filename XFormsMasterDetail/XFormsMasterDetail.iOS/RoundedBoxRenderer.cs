using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.iOS;

[assembly: ExportRenderer(typeof(RoundedBoxView), typeof(RoundedBoxRenderer))]

namespace XFormsMasterDetail.iOS
{
    public class RoundedBoxRenderer : BoxRenderer
    {
        public RoundedBoxRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Layer.MasksToBounds = true;
                Layer.CornerRadius = (float)((RoundedBoxView)this.Element).CornerRadius / 2.0f;
            }
        }
    }
}
