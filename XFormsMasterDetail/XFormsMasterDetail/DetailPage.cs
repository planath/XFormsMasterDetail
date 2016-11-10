using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsMasterDetail
{
    class DetailPage : ContentPage
    {
        public DetailPage()
        {
            var label1 = new Label();
            label1.SetBinding(Label.TextProperty, "Title");

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0,30,0,0),
                Children = {label1}
            };
        }
    }
}
