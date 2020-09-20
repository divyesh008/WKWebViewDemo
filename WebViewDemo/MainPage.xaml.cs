using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pdfWebView.Source = "https://drive.google.com/viewerng/viewer?embedded=true&url=https://sulam.s3.eu-central-1.amazonaws.com/heb_tes_kerech-1_helek-1.pdf";
            //pdfWebView.Source = "https://google.com";
        }
    }
}
