using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsMasterDetail.Helper
{
    public static class ColorExtension
    {
        public static Color AppMainColor(this Color c)
        {
            return Color.FromRgb(0, 153, 153);
        }
    }
}
