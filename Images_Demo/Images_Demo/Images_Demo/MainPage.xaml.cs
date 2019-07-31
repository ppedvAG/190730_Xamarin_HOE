using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Images_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //UriImageSource src = (UriImageSource)ImageSource.FromUri(new Uri("https://baconmockup.com/500/500"));
            //// Standardfall: 
            //src.CachingEnabled = true;
            //src.CacheValidity = TimeSpan.FromHours(24);

            //imageBild.Source = src;


            // Variante 2) FromFile: Ladet das Bild aus dem nativen Projekt
            // Android: 
            // imageBild.Source = ImageSource.FromFile("Icons/katze.png");


            // Variante 3)

            // Ressourcenstring: "Applikationsname.Ordnername.Dateiname.extension"
            // imageBild.Source = ImageSource.FromResource("Images_Demo.Icons.hund.jpg");
        }
    }
}
