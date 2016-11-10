using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsMasterDetail
{
    class CustomImageCell : TextCell
    {
        public CustomImageCell()
        {
            this.SetBinding(TextProperty, "Title");
            this.SetBinding(DetailProperty, "IpDns");
            this.SetBinding(DetailColorProperty, "Color");
        }
    }
}
