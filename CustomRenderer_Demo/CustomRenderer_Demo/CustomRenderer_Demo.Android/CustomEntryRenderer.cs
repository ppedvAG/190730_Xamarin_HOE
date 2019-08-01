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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Content.Res;
[assembly: ExportRenderer(typeof(Entry), typeof(CustomRenderer_Demo.Droid.CustomEntryRenderer))]
namespace CustomRenderer_Demo.Droid
{
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
               Control.SetTextColor(Android.Graphics.Color.Red);

        }
    }
}