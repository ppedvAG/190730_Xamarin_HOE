using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationStoragePage : ContentPage
    {
        public ApplicationStoragePage()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            if (App.Current.Properties.ContainsKey("entryName") == false)
            {
                App.Current.Properties.Add("entryName", entryName.Text);
                App.Current.Properties.Add("entryPasswort", entryPasswort.Text);
                App.Current.Properties.Add("switchNotifications", switchNotifications.IsToggled);
            }
            else
            {
                App.Current.Properties["entryName"] = entryName.Text;
                App.Current.Properties["entryPasswort"] = entryPasswort.Text;
                App.Current.Properties["switchNotifications"] = switchNotifications.IsToggled;
            }

            DisplayAlert("Speichern", "Ihre Daten wurden 'gespeichert'", "Ok");
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (App.Current.Properties.ContainsKey("entryName"))
            {
                entryName.Text = (string)App.Current.Properties["entryName"];
                entryPasswort.Text = (string)App.Current.Properties["entryPasswort"];
                switchNotifications.IsToggled = (bool)App.Current.Properties["switchNotifications"];
            }
        }
    }
}