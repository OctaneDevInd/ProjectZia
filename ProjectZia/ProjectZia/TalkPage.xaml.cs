using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.TextToSpeech;

namespace ProjectZia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TalkPage : ContentPage
	{
		public TalkPage ()
		{
			InitializeComponent ();
		}

        private void SpeakButton_Clicked(object sender, EventArgs e)
        {
            Plugin.TextToSpeech.Abstractions.CrossLocale crossLocale = new Plugin.TextToSpeech.Abstractions.CrossLocale
            {
                Language = "en-US"
            };
            if (speakEditor.Text == string.Empty)
            {
                DisplayAlert("Oops!", "There is no text to speak, buddy. Try entering some first.", "OK");
            }
            else
                CrossTextToSpeech.Current.Speak(speakEditor.Text,crossLocale);
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            if (speakEditor.Text == string.Empty)
            {
                DisplayAlert("Oops!", "There is no text to clear, buddy! Try entering some text first.", "OK");
            }
            else
                speakEditor.Text = string.Empty;
        }

        private void ButtonA_Clicked(object sender, EventArgs e)
        { 
            string text ="A";
  
            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonB_Clicked(object sender, EventArgs e)
        {
            string text = "B";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonC_Clicked(object sender, EventArgs e)
        {
            string text = "C";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonD_Clicked(object sender, EventArgs e)
        {
            string text = "D";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonE_Clicked(object sender, EventArgs e)
        {
            string text = "E";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonF_Clicked(object sender, EventArgs e)
        {
            string text = "F";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonG_Clicked(object sender, EventArgs e)
        {
            string text = "G";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonH_Clicked(object sender, EventArgs e)
        {
            string text = "H";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonI_Clicked(object sender, EventArgs e)
        {
            string text = "I";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonJ_Clicked(object sender, EventArgs e)
        {
            string text = "J";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonK_Clicked(object sender, EventArgs e)
        {
            string text = "K";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonL_Clicked(object sender, EventArgs e)
        {
            string text = "L";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonM_Clicked(object sender, EventArgs e)
        {
            string text = "M";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonN_Clicked(object sender, EventArgs e)
        {
            string text = "N";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonO_Clicked(object sender, EventArgs e)
        {
            string text = "O";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonP_Clicked(object sender, EventArgs e)
        {
            string text = "P";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonQ_Clicked(object sender, EventArgs e)
        {
            string text = "Q";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonR_Clicked(object sender, EventArgs e)
        {
            string text = "R";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonS_Clicked(object sender, EventArgs e)
        {
            string text = "S";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonT_Clicked(object sender, EventArgs e)
        {
            string text = "T";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonU_Clicked(object sender, EventArgs e)
        {
            string text = "U";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonV_Clicked(object sender, EventArgs e)
        {
            string text = "V";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonW_Clicked(object sender, EventArgs e)
        {
            string text = "W";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonX_Clicked(object sender, EventArgs e)
        {
            string text = "X";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonY_Clicked(object sender, EventArgs e)
        {
            string text = "Y";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }

        private void ButtonZ_Clicked(object sender, EventArgs e)
        {
            string text = "Z";

            if (speakEditor.Text == string.Empty)
            {
                speakEditor.Text = text;
            }
            else
                speakEditor.Text += text.ToLower();
        }
    }
}