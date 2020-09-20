using System;
using System.ComponentModel;

namespace WebViewDemo.ViewModel
{
    public class WKWebPageViewModel : BaseViewModel
    {
        public WKWebPageViewModel()
        {
            AccountPageURL = "https://plaid.com/demo/?countryCode=US&language=en&product=transactions"; //"http://34.216.71.66/Plaid/Plaid";
        }

        private string _accountPageURL;
        public string AccountPageURL
        {
            get { return _accountPageURL; }
            set
            {
                _accountPageURL = value;
                RaisePropertyChanged(nameof(AccountPageURL));
            }
        }
    }
}
