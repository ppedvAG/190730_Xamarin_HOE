using MVVM_Simpel.Models;
using MVVM_Simpel.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Simpel
{
    class ViewModelLocator
    {
        // Alternative: IoC - Container
        // Unity, AutoFac, SimpeIoC ....

        private PersonenService service;
        public PersonenService Service
        {
            get
            {
                service = service ?? new PersonenService();
                return service;
            }
        }


        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                main = main ?? new MainViewModel(Service);
                return main;
            }
        }
    }
}
