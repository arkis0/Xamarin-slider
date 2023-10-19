using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        string[] Quotes =
        {
            "Quote 1",
            "Quote 2",
            "Quote 3"
        };
        int CurrentQuoteIndex = 0;

        public MainPage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {
                Padding = new Thickness(20, 30, 20, 20);
            } 
            else if(Device.RuntimePlatform == "WinPhone")
            {
                Padding = new Thickness(20, 40, 20, 20);
            }

            quoteText.BindingContext = this;
            quoteText.Text = Quotes[CurrentQuoteIndex];
        }
        void ChangeQuote(object sender, EventArgs args)
        {
            CurrentQuoteIndex++;
            if (CurrentQuoteIndex >= Quotes.Length)
            {
                CurrentQuoteIndex = 0;
            }
            quoteText.Text = Quotes[CurrentQuoteIndex];
        }
    }
}