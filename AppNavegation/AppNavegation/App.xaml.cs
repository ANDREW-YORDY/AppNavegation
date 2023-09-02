using AppNavegation.Services;
using AppNavegation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavegation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            /* carga la image de fondo, al ejecutar app
            MainPage = new ContentPage
            {
                BackgroundImage = "barranquilla_ventana.jpg",
                // Aquí puede agregar otros elementos de la página principal
            };
            */

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
