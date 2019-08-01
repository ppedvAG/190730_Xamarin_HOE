using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestPage : ContentPage
    {
        public RestPage()
        {
            InitializeComponent();
        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            // 1) Herunterladen
            string json;
            using(HttpClient client = new HttpClient())
            {
                json = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            }

            // 2) Deserialisieren und Anzeigen
            listViewToDo.ItemsSource = JsonConvert.DeserializeObject<ToDoItem[]>(json);

            listViewToDo.EndRefresh();
        }
    }
}