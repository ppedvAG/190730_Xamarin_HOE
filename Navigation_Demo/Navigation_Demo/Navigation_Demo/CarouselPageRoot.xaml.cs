﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageRoot : CarouselPage
    {
        public CarouselPageRoot()
        {
            InitializeComponent();
        }
    }
}