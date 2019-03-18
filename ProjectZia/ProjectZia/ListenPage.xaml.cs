using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.AudioRecorder;
using Pocketsphinx;


namespace ProjectZia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListenPage : ContentPage
	{
        //Pocketsphinx.Decoder d;
        //Config c;
        AudioRecorderService recorder;
        AudioPlayer player;
        string audioFile;
        public ListenPage ()
		{
			InitializeComponent ();
            //try
            //{
            //    c = Pocketsphinx.Decoder.DefaultConfig();
            //    c.SetString("-hmm", "/models/en-us/mdef");
            //    c.SetString("-dict", "/models/dict/cmudict-en-us.dict");
            //    c.SetFloat("-kws_threshold", 1e-30);

            //    c.SetFloat("-samprate", 44100);
            //    c.SetInt("-nfft", 2048);

            //    d = new Pocketsphinx.Decoder(c);
            //}catch(Exception ex)
            //{
            //    DisplayAlert("Oops!", ex.Message, "OK");
            //}
            recorder = new AudioRecorderService
            {
                StopRecordingAfterTimeout = false,
                //AudioSilenceTimeout = TimeSpan.FromSeconds(2),
                //TotalAudioTimeout = TimeSpan.FromSeconds(20)
            };
            
            //recorder.FilePath = "/audio";
            player = new AudioPlayer();
            player.FinishedPlaying += Player_FinishedPlaying;
        }

        private void Player_FinishedPlaying(object sender, EventArgs e)
        {
            playRecordingButton.IsEnabled = true;
            startListeningButton.IsEnabled = true;
        }
        async Task<string> WaitForSpeechToText()
        {
            return await DependencyService.Get<ISpeechToText>().SpeechToTextAsync();
        }

        //static byte[] convertToBytes(float[] data, int channels)
        //{
        //    float tot = 0;
        //    byte[] byteData = new byte[data.Length / channels * 2];
        //    for (int i = 0; i < data.Length / channels; i++)
        //    {
        //        float sum = 0;
        //        for (int j = 0; j < channels; j++)
        //        {
        //            sum += data[i * channels + j];
        //        }
        //        tot += sum * sum;
        //        short val = (short)(sum / channels * 20000); // volume
        //        byteData[2 * i] = (byte)(val & 0xff);
        //        byteData[2 * i + 1] = (byte)(val >> 8);
        //    }
        //    //Debug.Log (Math.Sqrt(tot / data.Length / channels));
        //    return byteData;
        //}

        private async void StartListeningButton_Clicked(object sender, EventArgs e)
        {

            //await RecordAudio();
            var speech=await WaitForSpeechToText();
            listenlabel.Text = speech;
            

        }
        private async Task RecordAudio()
        {
            try
            {
                if(!recorder.IsRecording)
                {
                    playRecordingButton.IsEnabled = false;

                    var audiorecordTask = await recorder.StartRecording();
                    startListeningButton.Text = "Stop Listening";

                    audioFile = await audiorecordTask;
                    startListeningButton.Text = "Start Listening";
                    playRecordingButton.IsEnabled = true;
                    listenlabel.Text = audioFile;
                    //player.Play(audioFile);
                }
                else
                {
                    startListeningButton.IsEnabled = false;
                    await recorder.StopRecording();
                    player.Play(audioFile);
                    startListeningButton.IsEnabled = true;
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error occured in recording audio.", ex.Message, "OK");
            }
        }

        private void PlayRecordingButton_Clicked(object sender, EventArgs e)
        {
             PlayAudioAsync();
        }

        private void PlayAudioAsync()
        {
            try
            {
                var filePath = audioFile;

                if (filePath != null)
                {
                    listenlabel.Text = filePath;
                    playRecordingButton.IsEnabled = false;
                    startListeningButton.IsEnabled = false;
                    try
                    {
                        player.Play(filePath);
                    }catch(Exception exx)
                    {
                        DisplayAlert("Oops", exx.Message, "OK");
                    }
                    finally
                    {
                        playRecordingButton.IsEnabled = true;
                        startListeningButton.IsEnabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //blow up the app!
                DisplayAlert("Oops", ex.Message, "Ok");
            }
        }
    }
}