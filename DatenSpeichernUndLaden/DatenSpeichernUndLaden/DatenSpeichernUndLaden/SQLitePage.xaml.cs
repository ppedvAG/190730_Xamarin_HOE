using SQLite;
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
    public partial class SQLitePage : ContentPage
    {
        public SQLitePage()
        {
            InitializeComponent();

            string databasePath = Path.Combine(FileSystem.AppDataDirectory, "demo.db");
            con = new SQLiteConnection(databasePath); // Wenn die DB nicht existiert, wird sie automatisch erstellt
            con.CreateTable<ToDoItem>(); // Wenn die Tabelle bereits existiert, passiert nichts 
        }

        private SQLiteConnection con;

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            listViewToDo.ItemsSource = con.Table<ToDoItem>().ToList();
            listViewToDo.EndRefresh();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ToDoItem item = new ToDoItem { Title = entryTitle.Text, Completed = switchCompleted.IsToggled };
            con.Insert(item);
        }
    }
}