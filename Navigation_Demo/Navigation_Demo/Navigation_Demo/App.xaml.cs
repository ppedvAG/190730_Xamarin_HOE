﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new NavigationPage(new MainPage());
            // MainPage = new TabPageRoot();
            // MainPage = new CarouselPageRoot();
            // MainPage = new MD.MasterDetailPage_Root();

            MainPage = new ShellPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
