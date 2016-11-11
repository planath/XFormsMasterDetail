using Xamarin.Forms;

namespace XFormsMasterDetail
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

////public static readonly BindableProperty TitleProperty =
////BindableProperty.Create("Title", typeof(string), typeof(BindingTextCell), "");
////public string Title
////{
////    get { return (string)GetValue(TitleProperty); }
////    set { SetValue(TitleProperty, value); }
////}

////public static readonly BindableProperty SubTitleProperty =
////  BindableProperty.Create("SubTitle", typeof(string), typeof(BindingTextCell), "");
////public string SubTitle
////{
////    get { return (string)GetValue(SubTitleProperty); }
////    set { SetValue(SubTitleProperty, value); }
////}

////public static readonly BindableProperty ColorProperty =
////  BindableProperty.Create("Color", typeof(string), typeof(BindingTextCell), "");
////public string Color
////{
////    get { return (string)GetValue(ColorProperty); }
////    set { SetValue(ColorProperty, value); }
////}

//public BindingTextCell()
//{
//    //this.SetBinding(TitleProperty, "Title");
//    //this.SetBinding(SubTitleProperty, "SubTitle");
//    //this.SetBinding(ColorProperty, "Color");


//    var titleLabel = new Label()
//    {
//        FontSize = 22,
//        FontAttributes = FontAttributes.Bold
//    };
//    titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

//    var subTitleLabel = new Label()
//    {
//        FontSize = 22
//    };
//    subTitleLabel.SetBinding(Label.TextProperty, new Binding("SubTitle"));

//    var colorBox = new BoxView
//    {
//        WidthRequest = 15,
//        HeightRequest = View.Height,
//        HorizontalOptions = LayoutOptions.Start,
//        VerticalOptions = LayoutOptions.Center
//    };
//    colorBox.SetBinding(BoxView.ColorProperty, new Binding("Color"));

//    View = new StackLayout()
//    {
//        Orientation = StackOrientation.Horizontal,
//        Children =
//                    {
//                        colorBox,
//                        new StackLayout()
//                        {
//                            Orientation = StackOrientation.Vertical,
//                            Children = {titleLabel, subTitleLabel}
//                        }
//                    }
//    };

//    //View.SetBinding(View.BackgroundColorProperty, new Binding("Color"));
//}
