using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXamarinForms
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Dialog / "MessageBox"

            // Variante 1: Normale Message anzeigen
            await DisplayAlert("Meine erste MessageBox", "Hallo Welt !", "Yay");

            // Variante 2: Ja/Nein - MessageBox

            // Variante 2.1: ohne async/await
            // bool result = DisplayAlert("Frage", "Ist jetzt schon Mittagspause ?", "Ja", "Verdammt nochmal Ja").Result;
            // Variante 2.2: mit async/await
            bool result = await DisplayAlert("Frage", "Ist jetzt schon Mittagspause ?", "Ja", "Verdammt nochmal Ja");

            await DisplayAlert("Deine Antwort war:", result.ToString(), "Ok");

            // Variante 3: Mehrere Optionen
            string obst = await DisplayActionSheet("Welches Obst willst du als Nachspeise haben?", null, null, "Apfel", "Birne", "Banane", "Orange");
            await DisplayAlert("Deine Nachspeise ist:", obst, "Mjam ....");


            await DisplayAlert("Username:", entryUsername.Text, "Okay");
        }
    }
}
