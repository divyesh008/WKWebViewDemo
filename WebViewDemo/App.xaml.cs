using System;
using WebViewDemo.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new WKWebPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
