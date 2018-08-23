﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace NRGScoutingApp
{
    public partial class MatchEvents : ContentPage
    {
        public MatchEvents()
        {
            InitializeComponent();
        }

         async void backClicked (object sender, System.EventArgs e)
        {
            var text = await DisplayAlert("Alert", "Do you want to discard progress?", "Yes", "No");
            //Boolean nav = (Boolean) text;
            if (text){
                Application.Current.Properties["teamStart"] = "";
                await Navigation.PopToRootAsync();

            }
            else{
                
            }
        }
        void saveClicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties["teamStart"] = "";
            Application.Current.Properties["appState"] = 0;
            App.Current.Properties["timerValue"] = 0;
            Navigation.PopToRootAsync();
        }

      }
}

//void timerConfirm()
//{
    //if ((int)(App.Current.Properties["timerValue"]) >= 0)
    //{
    //        private double timerrValue = (int)(App.Current.Properties["timerValue"]);
    //}
    //        else{
    //            private double timerrValue;
    //        }
    //}