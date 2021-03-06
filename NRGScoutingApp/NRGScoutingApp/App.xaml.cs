﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using System.Security.Principal;
using BottomBar.XamarinForms;


namespace NRGScoutingApp
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";


        public App()
        {
            InitializeComponent();
            Application.Current.MainPage = new NavigationPage(new NavTab());
            MainPage = new NavigationPage(new NavTab());
            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();         
        }

        public static String matchInfo = "";
        public static String matchEvents = "*(";


        public class NavTab: BottomBarPage
        {
            public NavTab()
            {
                Children.Add(new Matches());
                Children.Add(new Rankings());

            }
        }

    }
}
