using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.iOS;

//[assembly: ExportRenderer(typeof(RoundedBoxView), typeof(RoundedBoxRenderer))]

namespace XFormsMasterDetail.iOS
{
    public class RoundedBoxRenderer : BoxRenderer
    {
        public RoundedBoxRenderer()
        {
        }

        public override void Draw(CGRect rect)
        {
            var rbv = Element as RoundedBoxView;

            using (var context = UIGraphics.GetCurrentContext())
            {
                context.SetFillColor(rbv.Color.ToUIColor().CGColor);
                context.SetStrokeColor(rbv.OutlineColor.ToUIColor().CGColor);
                context.SetLineWidth(3);

                CGRect rc = this.Bounds.Inset(3, 3);
                nfloat radius = (nfloat) rbv.CornerRadius;

                nfloat maxRadius = (rc.Height/2 > rc.Width/2) ? rc.Height/2 : rc.Width/2;
                nfloat minRadius = (radius < maxRadius) ? radius : maxRadius;
                radius = (minRadius >= 0) ? minRadius : 0;
                
                var path = CGPath.FromRoundedRect(rc, radius, radius);
                context.AddPath(path);
                context.DrawPath(CGPathDrawingMode.FillStroke);
            }

        }
    }
}
