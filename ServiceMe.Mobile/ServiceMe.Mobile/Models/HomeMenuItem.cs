using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceMe.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Customers,
        Jobs
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
