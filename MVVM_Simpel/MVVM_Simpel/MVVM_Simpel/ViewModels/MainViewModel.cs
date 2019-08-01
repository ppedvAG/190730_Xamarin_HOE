using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class MainViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            service = new PersonenService();

            GetPersonenCommand = new Command(GetPersonen);
        }

        private readonly PersonenService service;

        public List<Person> Personen { get; set; }

        public ICommand GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personen = service.GetPersonen();
        }
    }
}