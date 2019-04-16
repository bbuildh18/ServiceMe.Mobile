using ServiceMe.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceMe.Mobile.ViewModels
{
    public class JobDetailViewModel
    {
        public int MyProperty { get; set; }
        public JobsMenuItem Item { get; set; }

        public JobDetailViewModel(JobsMenuItem Item)
        {
            this.Item = Item;
        }
        
        public string Title { get; set; }
        public string JobDescription { get; set; }
    }
}
