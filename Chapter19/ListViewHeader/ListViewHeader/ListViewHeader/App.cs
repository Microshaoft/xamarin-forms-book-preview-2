﻿using System;
using Xamarin.Forms;

namespace ListViewHeader
{
    public class App : Application
    {
        public App()
        {
            ElPasoHighSchool.Library.Init();

            MainPage = new ListViewHeaderPage();
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
