using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutContainer
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            Button auslöser = (Button)sender;
            // Style zur Laufzeit zuweisen
            // auslöser.Style = (Style)App.Current.Resources["specialButtonStyle"];

            // Style zur Laufzeit im Dictioanry austauschen:
            // StaticResource -> Änderung wird nicht übernommen (Button 4 und 5)
            // DynamicResource -> Änderung wird erkannt und übernommen (Button 6)
            gridRoot.Resources["specialButtonStyle"] = (Style)App.Current.Resources["specialButtonStyle"];
        }
    }
}
