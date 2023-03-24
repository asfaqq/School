using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using проект.Views;

namespace проект.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
