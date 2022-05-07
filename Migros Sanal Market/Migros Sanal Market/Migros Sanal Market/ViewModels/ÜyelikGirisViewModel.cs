using Migros_Sanal_Market.Views;
using Migros_Sanal_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Migros_Sanal_Market.ViewModels
{
    public class ÜyelikGirisViewModel : ContentView
    {
       
        public ÜyelikGirisViewModel()
        {
        }
        private async void OnÜyeOl(object obj)
        {
            await Shell.Current.GoToAsync(nameof(ÜyelikPage));
        }
        private async void OnGirisYap(object obj)
        {
            await Shell.Current.GoToAsync(nameof(GirişYapPage));
        }


    }
}