using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Pocketsphinx;

namespace ProjectZia
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListenPage());
        }

        private void TalkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TalkPage());
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            
        }
    }
}
