using System;
using Foundation;
using WebKit;
using Xamarin.Forms.Platform.iOS;

namespace WebViewDemo.iOS
{
    public class CustomWebViewRenderer : WkWebViewRenderer
    {
        public CustomWebViewRenderer()
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
        }

        private class AuthenticatingWebViewDelegate : WKNavigationDelegate, INSUrlConnectionDelegate
        {
            public override void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
            {
                base.DidFailNavigation(webView, navigation, error);
            }

            public override void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
            {
                base.DidFinishNavigation(webView, navigation);
            }

            public override void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
            {
                base.DidStartProvisionalNavigation(webView, navigation);
            }
        }
    }
}
