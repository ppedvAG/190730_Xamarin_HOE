using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listen
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Person[] personen =
            {
                new Person{Vorname="Tom",Nachname ="Ate",Alter=10,Kontostand = 100},
                new Person{Vorname="Anna",Nachname ="Nass",Alter=20,Kontostand = 123},
                new Person{Vorname="Peter",Nachname ="Silie",Alter=30,Kontostand = 1042340},
                new Person{Vorname="Franz",Nachname ="Ose",Alter=40,Kontostand = -234234100},
                new Person{Vorname="Martha",Nachname ="Pfahl",Alter=50,Kontostand = 9087654},
                new Person{Vorname="Rainer",Nachname ="Zufall",Alter=60,Kontostand = 234234},
                new Person{Vorname="Klara",Nachname ="Fall",Alter=70,Kontostand = 12113100},
                new Person{Vorname="Albert",Nachname ="Tross",Alter=80,Kontostand = -123123100},
                new Person{Vorname="Anna",Nachname ="Bolika",Alter=90,Kontostand = 4423423423},
                new Person{Vorname="Clair",Nachname ="Grube",Alter=100,Kontostand = -12312312312312312},
            };
            listViewPersonen.ItemsSource = personen;
        }
    }
}
