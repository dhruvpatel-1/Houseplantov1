﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioB.Models;
using StudioB.Views.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioB.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listview; } }

        public List<MasterMenuItem> items;

        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        private void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Plants", "icon.png", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("InfoScreen2", "icon.png", Color.White, typeof(InfoScreen2)));

            ListView.ItemsSource = items;
        }
    }
}