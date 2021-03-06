using ForMenApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForMenApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();

            BindingContext = new HomePageVM(); 
        }

        private void menuBtnClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private async void btnCarrito(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarritoPage(), false);
        }
    }
}