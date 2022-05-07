using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Migros_Sanal_Market.Models;
using Migros_Sanal_Market.ViewModels;
using Migros_Sanal_Market.Views;

namespace Migros_Sanal_Market.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HesabımPage : ContentPage

    {
        
        public HesabımPage()
        {
            InitializeComponent();
           
        }

        private async void UyeGiris_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ÜyelikGirisPage());
            
        }
        

        
    }
}