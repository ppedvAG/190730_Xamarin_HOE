using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileSystemPage : ContentPage
    {
        public FileSystemPage()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            // Ort ???
            // C:\\Users\\Michael\\AppData\\.....
            // \storage\emulated\0\DCIM\asdsadads

            var fullpath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            File.WriteAllText(fullpath, entryData.Text);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            var fullpath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            DisplayAlert("Datei:", File.ReadAllText(fullpath), "Ok");
        }
    }
}