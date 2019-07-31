using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Sensorik
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            if(e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
            {
                stackLayoutLandscape.IsVisible = false;
                stackLayoutPortrait.IsVisible = true;
            }
            else
            {
                stackLayoutLandscape.IsVisible = true;
                stackLayoutPortrait.IsVisible = false;
            }
        }
    }
}
