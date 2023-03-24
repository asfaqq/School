using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace проект.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Главная";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://ykt-s39.obr.sakha.gov.ru/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}