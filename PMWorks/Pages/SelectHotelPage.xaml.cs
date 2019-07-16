﻿using System.Collections.ObjectModel;

namespace PMWorks.Pages


            BindingContext = Hotels;


        private async void Collview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = (e.CurrentSelection.FirstOrDefault() as HotelsList)?.HotelName;

            await Navigation.PushAsync(new MenuPage(name));

            //await Navigation.PushAsync(new NotificationsPage());
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))