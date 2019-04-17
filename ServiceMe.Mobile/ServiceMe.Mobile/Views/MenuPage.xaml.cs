﻿using ServiceMe.Mobile.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServiceMe.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                //new HomeMenuItem {Id = MenuItemType.Customers, Title="Customers" },
                //new HomeMenuItem {Id = MenuItemType.JobMaster, Title="Jobs" }
            };

            menuItems.Add(new HomeMenuItem { Id = MenuItemType.About, Title = "About" });

            if (Utility.Role == "Consumer")
            {
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.JobMaster, Title = "Jobs" });

            }
            else
            {
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.Browse, Title = "Browse" });
            }


            //    menuItems.Add(new HomeMenuItem { Id = MenuItemType.Customers, Title = "Customers" });


            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}