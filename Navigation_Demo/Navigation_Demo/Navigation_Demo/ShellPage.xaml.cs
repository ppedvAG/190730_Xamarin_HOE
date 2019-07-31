using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellPage : Shell
    {
        public ShellPage()
        {
            InitializeComponent();
        }

        private void ButtonZurHauptseite_Clicked(object sender, EventArgs e)
        {
            // Navigation: Absolut
            // Shell.Current.GoToAsync("//Hauptmenü/Hauptseite/ContentHauptseite");

            // Navigation: Relativ
            Shell.Current.GoToAsync("//ContentHauptseite");

            // Routen Registrieren:
            // Routing.RegisterRoute("abcde", typeof(Seite2));
        }
    }
}