﻿using System;
using System.Collections.Generic;
using System.Collections;
using Xamarin.Forms;

namespace NRGScoutingApp
{
    public partial class MatchEntryEditTab : TabbedPage
    {
        public MatchEntryEditTab()
        {
            //TabbedPage.SetBinding(MatchEntryEditTab.TitleProperty = teamAssign.teamName);
            ArrayList vals = new ArrayList();
            StringFormat s = new StringFormat();
            vals = s.ParseMatchParam(App.Current.Properties[App.Current.Properties["teamStart"].ToString() + "converted"].ToString());
            Children.Add(new NewMatchStart());
            Children.Add(new MatchEvents());
            Children.Add(new MatchParameters(vals));
            BindingContext = this;
            App.Current.Properties["newAppear"] = 1;
            App.Current.SavePropertiesAsync();
            InitializeComponent();
        }
        string titleName = (App.Current.Properties["teamStart"].ToString());
        public string teamName { get { return titleName; } }
    }
}
