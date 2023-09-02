using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppNavegation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About-Barranquilla";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.barranquilla.gov.co/descubre/conoce-a-barranquilla"));
        }

        public ICommand OpenWebCommand { get; }
    }
}