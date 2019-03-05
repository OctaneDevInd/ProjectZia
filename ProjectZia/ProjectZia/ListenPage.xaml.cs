using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProjectZia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListenPage : ContentPage
	{
		public ListenPage ()
		{
			InitializeComponent ();
		}

        private void StartListeningButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}