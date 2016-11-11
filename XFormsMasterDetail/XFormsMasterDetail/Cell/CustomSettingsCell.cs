using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsMasterDetail
{
    class CustomSettingsCell : TextCell
    {
        public CustomSettingsCell()
        {
            this.SetBinding(TextProperty, "Title");
        }
    }
}
