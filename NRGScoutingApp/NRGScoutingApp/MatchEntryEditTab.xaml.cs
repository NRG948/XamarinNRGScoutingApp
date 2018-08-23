﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NRGScoutingApp
{
    public partial class MatchEntryEditTab : TabbedPage
    {
        public MatchEntryEditTab()
        {
            //TabbedPage.SetBinding(MatchEntryEditTab.TitleProperty = teamAssign.teamName);
          
            Children.Add(new NewMatchStart());
            Children.Add(new MatchParameters());
            Children.Add(new MatchEvents());
            BindingContext = this;
           
        InitializeComponent();
        }
        string titleName = (App.Current.Properties["teamStart"].ToString());
        public string teamName { get { return titleName; } }

    }
}
