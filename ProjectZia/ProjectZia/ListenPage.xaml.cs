using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using Pocketsphinx;


namespace ProjectZia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListenPage : ContentPage
	{
        Pocketsphinx.Decoder d;
        Config c;
        public ListenPage ()
		{
			InitializeComponent ();
            try
            {
                c = Pocketsphinx.Decoder.DefaultConfig();
                c.SetString("-hmm", "/models/en-us/mdef");
                c.SetString("-dict", "/models/dict/cmudict-en-us.dict");
                c.SetFloat("-kws_threshold", 1e-30);

                c.SetFloat("-samprate", 44100);
                c.SetInt("-nfft", 2048);

                d = new Pocketsphinx.Decoder(c);
            }catch(Exception ex)
            {
                DisplayAlert("Oops!", ex.Message, "OK");
            }
        }

        static byte[] convertToBytes(float[] data, int channels)
        {
            float tot = 0;
            byte[] byteData = new byte[data.Length / channels * 2];
            for (int i = 0; i < data.Length / channels; i++)
            {
                float sum = 0;
                for (int j = 0; j < channels; j++)
                {
                    sum += data[i * channels + j];
                }
                tot += sum * sum;
                short val = (short)(sum / channels * 20000); // volume
                byteData[2 * i] = (byte)(val & 0xff);
                byteData[2 * i + 1] = (byte)(val >> 8);
            }
            //Debug.Log (Math.Sqrt(tot / data.Length / channels));
            return byteData;
        }

        private void StartListeningButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                d.StartUtt();
            }
            catch(Exception ex)
            {
                DisplayAlert("Exception",ex.Message,"OK");
            }


        }
    }
}