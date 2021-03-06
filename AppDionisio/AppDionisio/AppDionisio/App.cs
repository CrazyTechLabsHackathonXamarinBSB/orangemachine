﻿using AppDionisio.Models;
using AppDionisio.Views;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppDionisio
{
    public class App : Application
    {
        public static MobileServiceClient MobileService = new MobileServiceClient(
            "https://dionisio.azure-mobile.net/",
            "xXVYABXIPgAfTKpqfKJaVIzrGqLerS25"
        );

        public static Usuario UsuarioLogado { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new LoginPage());
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
