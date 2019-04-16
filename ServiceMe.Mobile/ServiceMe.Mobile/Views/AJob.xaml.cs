﻿using ServiceMe.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServiceMe.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AJob : ContentPage
	{
        JobDetailViewModel jobDetailViewModel;

        public AJob (JobDetailViewModel jobDetailViewModel)
		{
			InitializeComponent ();
            BindingContext = this.jobDetailViewModel = jobDetailViewModel;

        }
        public AJob()
        {
            InitializeComponent();

            var item = new JobsMenuItem
            {
                Id = Guid.NewGuid().ToString(),
                Title = "This is an item description."
            };

            jobDetailViewModel = new JobDetailViewModel(item);
            BindingContext = jobDetailViewModel;
        }
    }
}