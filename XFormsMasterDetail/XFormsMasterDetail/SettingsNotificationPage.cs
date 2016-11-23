
using Xamarin.Forms;
using XFormsMasterDetail.Helper;
using XFormsMasterDetail.Model;
using XFormsMasterDetail.Repository;
using XFormsMasterDetail.View.Cell;

namespace XFormsMasterDetail
{
    public class SettingsNotificationPage : ContentPage
    {
        public SettingsNotificationPage()
        {
            var layout = new RelativeLayout() {Margin = 20};
            var listView = new ListView();
            var roundedBoxView = new RoundedBoxView() { Color = Color.White, CornerRadius = 18, OutlineColor = Color.Black };
            var referenceBoxView = new RoundedBoxView() { Color = Color.Transparent, CornerRadius = 10, OutlineColor = Color.Black, Opacity = 0};

            listView.ItemTemplate = new DataTemplate(typeof(CheckmarkViewCell));
            listView.ItemsSource = SettingsNotificationRepo.GetData();

            listView.ItemSelected += (sender, args) =>
            {
                foreach (Setting tone in listView.ItemsSource)
                {
                    tone.Checked = false;
                }
                (args.SelectedItem as Setting).Checked = true;
            };

            // constraints setup
            var centerX = Constraint.RelativeToParent(parent => parent.Width / 2);
            var centerY = Constraint.RelativeToParent(parent => parent.Height / 2);
            var widthBox = Constraint.RelativeToParent(p => p.Width + 6);
            var heightBox = Constraint.RelativeToParent(p => p.Height + 6);
            var widthList = Constraint.RelativeToParent(p => p.Width);
            var heightList = Constraint.RelativeToParent(p => p.Height);

            // add invisible reference-view to center-position
            layout.Children.Add(referenceBoxView, centerX, centerY, widthBox, heightBox);

            // position rounded background to reference-view and move to center by subtracting halve of its bounds
            layout.Children.Add(roundedBoxView,
                Constraint.RelativeToView(referenceBoxView, (parent, sibling) => sibling.X - sibling.Width / 2),
                Constraint.RelativeToView(referenceBoxView, (parent, sibling) => sibling.Y - sibling.Height / 2),
                widthBox,
                heightBox);

            // position rounded list to reference-view and move to center by subtracting halve of its bounds
            layout.Children.Add(listView,
                Constraint.RelativeToView(referenceBoxView, (parent, sibling) => sibling.X + 3 - sibling.Width / 2),
                Constraint.RelativeToView(referenceBoxView, (parent, sibling) => sibling.Y + 3 - sibling.Height / 2),
                widthList,
                heightList);

            Content = layout;
        }
    }
}
