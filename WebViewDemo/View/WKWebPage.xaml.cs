using System;
using System.Collections.Generic;
using WebViewDemo.ViewModel;
using Xamarin.Forms;

namespace WebViewDemo.View
{
    public partial class WKWebPage : ContentPage
    {
        public WKWebPage()
        {
            InitializeComponent();
            BindingContext = new WKWebPageViewModel();
        }
    }
}
