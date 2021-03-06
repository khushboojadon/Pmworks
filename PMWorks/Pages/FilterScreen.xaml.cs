﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PMWorks.Models;
using Xamarin.Forms;

namespace PMWorks.Pages
{
    public partial class FilterScreen : ContentPage
    {
        public static ObservableCollection<Grouping<string, CatogriesList>> HotelsGrouped { get; set; }

        public static ObservableCollection<CatogriesList> Catogries { get; set; }

        public FilterScreen()
        {
            InitializeComponent();
            // MyList.ItemsSource = new CatogriesList().ListOfCategory();
            Catogries = new CatogriesList().ListOfCategory();
            BindingContext = Catogries;

        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            //textlbl.Text = isToggled.ToString();
        }
        private async void Close_Clicked(object sender, System.EventArgs e)        {            await Navigation.PopAsync();        }        private async void BtnFilterClicked(object sender, EventArgs e)        {            await Navigation.PopAsync();        }
    }
}