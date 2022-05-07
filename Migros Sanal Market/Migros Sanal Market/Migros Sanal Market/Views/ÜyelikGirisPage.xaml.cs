using Migros_Sanal_Market.Models;
using Migros_Sanal_Market.ViewModels;
using Migros_Sanal_Market.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace Migros_Sanal_Market.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ÜyelikGirisPage : ContentPage
    {
        
        public ÜyelikGirisPage()
        {
            InitializeComponent();
           
        }

        private async void UyeOl_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ÜyelikPage ());

        }
        private async void GirisYap_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GirişYapPage());

        }
    }
}