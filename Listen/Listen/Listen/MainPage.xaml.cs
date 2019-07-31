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
            string[] personen = { "Tom Ate", "Anna Nass", "Peter Silie", "Martha Pfahl", "Franz Ose", "Klara Fall", "Rainer Zufall", "Frank N Stein", "Albert Tross", "Axel Schweiß", "Bill Dung", "Anna Bolika", "Clair Grube" };
            collectionViewPersonen.ItemsSource = personen;
        }
    }
}
