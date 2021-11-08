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
    public partial class CarritoPage : ContentPage
    {
        public CarritoPage()
        {
            InitializeComponent();
            BindingContext = new CarritoVM();
        }


        private void menuBtnClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}