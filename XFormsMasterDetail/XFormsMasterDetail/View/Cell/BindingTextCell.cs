using Xamarin.Forms;

namespace XFormsMasterDetail.View.Cell
{
    class BindingTextCell : TextCell
    {
        public BindingTextCell()
        {
            this.SetBinding(TextProperty, "Title");
            this.SetBinding(DetailProperty, "SubTitle");
            this.SetBinding(DetailColorProperty, "Color");
        }
    }
}
