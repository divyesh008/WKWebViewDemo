using System;
using Android.Content;
using Android.Views;
using WebViewDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(MyWebViewRenderer))]
namespace WebViewDemo.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        public MyWebViewRenderer(Context context) : base(context)
        {
        }

        public override bool DispatchTouchEvent(MotionEvent e)
        {
            Parent.RequestDisallowInterceptTouchEvent(true);
            return base.DispatchTouchEvent(e);
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            // Setting the background as transparent
            this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            if (e.OldElement == null)
            {
                Control.SetWebViewClient(new MyFormsWebViewClient(this));
            }
        }

        internal class MyFormsWebViewClient : FormsWebViewClient
        {
            MyWebViewRenderer _renderer;

            public MyFormsWebViewClient(MyWebViewRenderer renderer) : base(renderer)
            {
                _renderer = renderer;
            }

            public override void OnReceivedSslError(Android.Webkit.WebView view, Android.Webkit.SslErrorHandler handler, Android.Net.Http.SslError error)
            {
                handler.Proceed();
            }

            public override void OnPageFinished(Android.Webkit.WebView view, string url)
            {
                base.OnPageFinished(view, url);                
                view.ScrollChange += (sender, e) =>
                {
                    System.Diagnostics.Debug.WriteLine("Scroll Chnaged..!");
                };
            }

            public override void OnLoadResource(Android.Webkit.WebView view, string url)
            {
                base.OnLoadResource(view, url);
                var i = 1;
                System.Diagnostics.Debug.WriteLine("Called Time.. " + i++);
            }
        }
    }
}
