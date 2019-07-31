using Microcharts;
using SkiaSharp;
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

        private bool isOn = false;
        private void ButtonTaschenlampe_Clicked(object sender, EventArgs e)
        {
            if (isOn)
            {
                isOn = false;
                Flashlight.TurnOffAsync();
            }
            else
            {
                isOn = true;
                Flashlight.TurnOnAsync();
            }
            
        }

        private async void ButtonText2Speech_Clicked(object sender, EventArgs e)
        {
            var locale = await TextToSpeech.GetLocalesAsync();

            await TextToSpeech.SpeakAsync(entryTextToSpeech.Text,new SpeechOptions { Pitch = 1.5f,Locale = locale.ElementAt(1) });
        }

        private async void ButtonBrowser_Clicked(object sender, EventArgs e)
        {
            switch (Connectivity.NetworkAccess)
            {
                case NetworkAccess.Unknown:
                case NetworkAccess.None:
                case NetworkAccess.Local:
                    await DisplayAlert("Internet", " :( ", "Ok");
                    break;
                case NetworkAccess.ConstrainedInternet:
                    await DisplayAlert("Internet", "Welcome to China", "Ok");
                    break;
                case NetworkAccess.Internet:
                    await DisplayAlert("Internet", "Es geht ...","Ok");
                    break;
                default:
                    break;
            }

            await Browser.OpenAsync("https://www.orf.at");
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            // Chart befüllen:
            var entries = new[]
            {
                new Microcharts.Entry(55)
                {
                    Label = "January",
                    ValueLabel = "55",
                    Color = SKColor.Parse("#266489")
                },
                new Microcharts.Entry(145)
                {
                    Label = "February",
                    ValueLabel = "145",
                    Color = SKColor.Parse("#68B9C0")
                },
                new Microcharts.Entry(-32)
                {
                    Label = "March",
                    ValueLabel = "-32",
                    Color = SKColor.Parse("#90D585")
                }
            };

            var chart = new RadialGaugeChart() { Entries = entries };
            //chart.PointMode = PointMode.Square;
            //chart.PointSize = 5;

            chartView.Chart = chart;
        }
    }
}
