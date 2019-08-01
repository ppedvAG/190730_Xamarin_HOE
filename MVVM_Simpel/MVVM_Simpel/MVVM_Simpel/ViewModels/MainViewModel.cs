using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel(PersonenService service)
        {
            this.service = service;
            GetPersonenCommand = new Command(GetPersonen);
        }

        private readonly PersonenService service;

        private List<Person> personen;
        public List<Person> Personen
        {
            get => personen;
            set => SetValue(ref personen, value);
        }

        public ICommand GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personen = service.GetPersonen();

            // null-conditional operator, C# 6.0
            // if(person != null && person.GanzerName != null && person.GanzerName.Vorname != null)
            // if(person?.GanzerName?.Vorname != null)
        }
    }
}