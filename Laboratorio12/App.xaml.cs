﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.TaskPage());
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
