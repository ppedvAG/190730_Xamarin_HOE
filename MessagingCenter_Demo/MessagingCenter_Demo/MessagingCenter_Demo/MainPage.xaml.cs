using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenter_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Subscriber
            MessagingCenter.Subscribe<Slider>(this, "sliderValueChanged", ChangeLabel);
        }

        private void ChangeLabel(Slider sender)
        {
            labelWert.Text = sender.Value.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());

            // Alternative Navigation
            // App.Current.NavigateTo(typeof(Seite2)); // <== selbst implementieren !!!!
            // Shell.Current.GoToAsync("//demoseite");
        }
    }
}
