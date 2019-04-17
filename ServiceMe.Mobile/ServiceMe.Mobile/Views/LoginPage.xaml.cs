using ServiceMe.Mobile.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = loginViewModel = new LoginViewModel();

        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            Utility.Role = "Producer";

            if (loginViewModel.UserName == "prageeth")
            {
                Utility.Role= "Consumer";
            }
            //MessagingCenter.Send(this, "AddItem", Item);
            // await Navigation.PushModalAsync(new MainPage());
            Application.Current.MainPage = new MainPage();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
         //   await Navigation.PopModalAsync();
        }
    }
}