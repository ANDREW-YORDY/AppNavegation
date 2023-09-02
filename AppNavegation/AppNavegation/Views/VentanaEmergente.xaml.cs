using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNavegation.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VentanaEmergente : ContentPage
	{
		public VentanaEmergente ()
		{
			InitializeComponent ();
		}

        public void MostrarPaginaEmergente_Clicked(object sender, EventArgs e)
        {
            paginaEmergente.IsVisible = true;
        }

        public void CerrarPaginaEmergente_Clicked(object sender, EventArgs e)
        {
            paginaEmergente.IsVisible = false;
        }

    }
}