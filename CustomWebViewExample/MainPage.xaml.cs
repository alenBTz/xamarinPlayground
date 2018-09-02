using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomWebViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_SizeChanged(object sender, System.EventArgs e)
        {
            if (webView.Height == 0)
                return;
            Console.WriteLine("Loading finished");
        }
    }
}
