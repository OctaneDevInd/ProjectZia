using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Android;
using Android.Support.V7.Content;
using Android.Support.V7.App;
using Android.Support.V7;
using Android.Support.V7.AppCompat;
using Xamarin.Forms;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Speech.Tts;
using Android.Content;
using Android.Speech;

using System.Threading;
using ProjectZia;


namespace ProjectZia.Droid
{
    [Activity(Label = "ProjectZia", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //private string[] PermissionsArray;
        private const int VOICE = 10;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) != Permission.Granted || ContextCompat.CheckSelfPermission(this,Manifest.Permission.ReadExternalStorage) != Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio, Manifest.Permission.ReadExternalStorage }, 1);
          }
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.ModifyAudioSettings) != Permission.Granted || ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.ModifyAudioSettings, Manifest.Permission.WriteExternalStorage }, 1);
            }
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.MediaContentControl) != Permission.Granted || ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.MediaContentControl, Manifest.Permission.CaptureAudioOutput }, 1);
            }
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == VOICE)
            {
                if (resultCode == Result.Ok)
                {
                    var matches = data.GetStringArrayListExtra(RecognizerIntent.ExtraResults);
                    if (matches.Count != 0)
                    {
                        var textInput = matches[0];
                        if (textInput.Length > 500)
                            textInput = textInput.Substring(0, 500);
                        SpeechToText_Android.SpeechText = textInput;
                        
                    }
                }
                SpeechToText_Android.autoEvent.Set();
            }
        }

    }
}