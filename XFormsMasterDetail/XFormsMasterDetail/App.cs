using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFormsMasterDetail
{
    public class App : Application
    {
        public App()
        {
            if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
            {
                MainPage = new NavigationPage(new TabletMasterPage());
            }
            else
            {
                MainPage = new TabPage();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
