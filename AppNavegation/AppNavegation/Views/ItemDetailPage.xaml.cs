using AppNavegation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppNavegation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}