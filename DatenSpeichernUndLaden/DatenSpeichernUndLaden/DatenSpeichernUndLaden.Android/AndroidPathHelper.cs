using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidPathHelper))]
namespace DatenSpeichernUndLaden.Droid
{
    class AndroidPathHelper : IPathHelper
    {
        public string GetDirectoryPath()
        {
            Toast.MakeText(Application.Context, "Toastnachricht aus Android", ToastLength.Long).Show();
            return Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
        }
        // Für Windows:  System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
    }
}